using BLL;
using DAL;
using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class GestionOrdenesForm : Form
    {
        private readonly Form _menuForm;
        private readonly OrdenBss _ordenBss = new OrdenBss();
        private List<OrdenTrabajoEntity> _listaOrdenes = new List<OrdenTrabajoEntity>();

        public GestionOrdenesForm(Form menuForm)
        {
            InitializeComponent();
            _menuForm = menuForm;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            NavegacionHelper.VolverAMenu(this, _menuForm);
        }

        private void GestionOrdenesForm_Load(object sender, EventArgs e)
        {
            CargarOrdenesDePruebaConDatosReales();
        }

        /// <summary>
        /// Toma el primer vehículo y primer repuesto reales de la BD para armar casos de prueba
        /// listos para demostrar RN1, RN2, RN3, RN4 y el TransactionScope en la grilla.
        /// </summary>
        private void CargarOrdenesDePruebaConDatosReales()
        {
            int idVehiculoReal = 0;
            int kmActualReal = 0;
            int idRepuestoReal = 0;
            string descRepuestoReal = "Repuesto";
            decimal precioRepuestoReal = 0;
            int stockReal = 0;

            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                conn.Open();

                using (var cmdV = new SqlCommand("SELECT TOP 1 ID, KILOMETRAJE FROM Vehiculo ORDER BY ID", conn))
                using (var readerV = cmdV.ExecuteReader())
                {
                    if (readerV.Read())
                    {
                        idVehiculoReal = Convert.ToInt32(readerV["ID"]);
                        kmActualReal = Convert.ToInt32(readerV["KILOMETRAJE"]);
                    }
                }

                using (var cmdR = new SqlCommand("SELECT TOP 1 ID, DESCRIPCION, PRECIO, STOCK_FISICO FROM Repuesto ORDER BY ID", conn))
                using (var readerR = cmdR.ExecuteReader())
                {
                    if (readerR.Read())
                    {
                        idRepuestoReal = Convert.ToInt32(readerR["ID"]);
                        descRepuestoReal = readerR["DESCRIPCION"].ToString();
                        precioRepuestoReal = Convert.ToDecimal(readerR["PRECIO"]);
                        stockReal = Convert.ToInt32(readerR["STOCK_FISICO"]);
                    }
                }
            }

            if (idVehiculoReal == 0 || idRepuestoReal == 0)
            {
                MessageBox.Show(
                    "Cargá al menos 1 Cliente/Vehículo y 1 Repuesto con stock desde el menú antes de probar las órdenes.",
                    "Datos iniciales requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            _listaOrdenes = new List<OrdenTrabajoEntity>
            {
                // CASO 1: Válida -> Pasa RN1, RN2, RN3 y ejecuta TransactionScope en SQL Server
                new OrdenTrabajoEntity
                {
                    Id = 1,
                    IdVehiculo = idVehiculoReal,
                    KilometrajeIngreso = kmActualReal + 500,
                    Diagnostico = "Service completo y cambio de pieza (Válida para TransactionScope)",
                    Estado = "En Curso",
                    IdTecnico = 1,
                    ManoObra = 25000m,
                    CostoTotal = 25000m + precioRepuestoReal,
                    Detalles = new List<DetalleOrdenEntity>
                    {
                        new DetalleOrdenEntity
                        {
                            IdRepuesto = idRepuestoReal,
                            DescripcionRepuesto = descRepuestoReal,
                            Cantidad = 1,
                            PrecioUnitario = precioRepuestoReal
                        }
                    }
                },
                // CASO 2: Falla RN1 (Kilometraje menor al histórico del vehículo)
                new OrdenTrabajoEntity
                {
                    Id = 2,
                    IdVehiculo = idVehiculoReal,
                    KilometrajeIngreso = Math.Max(0, kmActualReal - 100),
                    Diagnostico = "Prueba fallo RN1 (Kilometraje menor)",
                    Estado = "En Curso",
                    IdTecnico = 1,
                    ManoObra = 15000m,
                    CostoTotal = 15000m,
                    Detalles = new List<DetalleOrdenEntity>()
                },
                // CASO 3: Falla RN2 (Cantidad requerida supera STOCK_FISICO)
                new OrdenTrabajoEntity
                {
                    Id = 3,
                    IdVehiculo = idVehiculoReal,
                    KilometrajeIngreso = kmActualReal + 600,
                    Diagnostico = "Prueba fallo RN2 (Stock insuficiente)",
                    Estado = "En Curso",
                    IdTecnico = 1,
                    ManoObra = 15000m,
                    CostoTotal = 15000m + (precioRepuestoReal * (stockReal + 10)),
                    Detalles = new List<DetalleOrdenEntity>
                    {
                        new DetalleOrdenEntity
                        {
                            IdRepuesto = idRepuestoReal,
                            DescripcionRepuesto = descRepuestoReal,
                            Cantidad = stockReal + 10,
                            PrecioUnitario = precioRepuestoReal
                        }
                    }
                },
                // CASO 4: Falla RN3 (Sin técnico asignado)
                new OrdenTrabajoEntity
                {
                    Id = 4,
                    IdVehiculo = idVehiculoReal,
                    KilometrajeIngreso = kmActualReal + 700,
                    Diagnostico = "Prueba fallo RN3 (Sin técnico)",
                    Estado = "En Curso",
                    IdTecnico = 0,
                    ManoObra = 10000m,
                    CostoTotal = 10000m,
                    Detalles = new List<DetalleOrdenEntity>()
                }
            };

            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = _listaOrdenes;
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ordenActual = (OrdenTrabajoEntity)dgvOrdenes.CurrentRow.DataBoundItem;

                // Ejecuta RN1 + RN2 + RN3 + TransactionScope (Inserta Orden, Detalle, descuenta Stock y actualiza Km)
                _ordenBss.CerrarOrden(ordenActual);

                MessageBox.Show(
                    $"Orden #{ordenActual.Id} finalizada con éxito.\n" +
                    $"Total liquidado (con IVA): {ordenActual.CostoTotal:C2}\n" +
                    $"Se descontó el stock y se actualizó el kilometraje en SQL Server.",
                    "Éxito - TransactionScope Completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Negocio / Rollback",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnularOrden_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ordenActual = (OrdenTrabajoEntity)dgvOrdenes.CurrentRow.DataBoundItem;

                _ordenBss.AnularOrden(ordenActual);

                MessageBox.Show("La orden fue anulada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Negocio (RN4)",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}