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
        private List<OrdenServicioEntity> _listaOrdenes = new List<OrdenServicioEntity>();

        public GestionOrdenesForm(Form menuForm)
        {
            InitializeComponent();
            _menuForm = menuForm;

            TemaUI.AplicarTemaFormulario(this);
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            NavegacionHelper.VolverAMenu(this, _menuForm);
        }

        private void GestionOrdenesForm_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        /// <summary>
        /// Toma el primer vehículo y primer repuesto reales de la BD para armar casos de prueba
        /// listos para demostrar RN1, RN2, RN3, RN4 y el TransactionScope en la grilla.
        /// </summary>
        private void CargarOrdenes()
        {
            try
            {
               this._listaOrdenes=this._ordenBss.getAll();
                RefrescarGrilla();
            }
            catch(Exception ex)
            {

            }        
             RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = _listaOrdenes;

            if (dgvOrdenes.Columns["IdOrden"] != null) dgvOrdenes.Columns["IdOrden"].HeaderText = "N° Orden";
            if (dgvOrdenes.Columns["IdVehiculo"] != null) dgvOrdenes.Columns["IdVehiculo"].HeaderText = "ID Vehículo";
            if (dgvOrdenes.Columns["IdTecnico"] != null) dgvOrdenes.Columns["IdTecnico"].HeaderText = "ID Técnico";
            if (dgvOrdenes.Columns["FechaIngreso"] != null)
            {
                dgvOrdenes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
                dgvOrdenes.Columns["FechaIngreso"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvOrdenes.Columns["FechaCierre"] != null)
            {
                dgvOrdenes.Columns["FechaCierre"].HeaderText = "Fecha de Cierre";
                dgvOrdenes.Columns["FechaCierre"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvOrdenes.Columns["Kilometraje"] != null)
            {
                dgvOrdenes.Columns["Kilometraje"].HeaderText = "Kilometraje";
                dgvOrdenes.Columns["Kilometraje"].DefaultCellStyle.Format = "N0";
            }
            if (dgvOrdenes.Columns["ManoObra"] != null)
            {
                dgvOrdenes.Columns["ManoObra"].HeaderText = "Mano de Obra";
                dgvOrdenes.Columns["ManoObra"].DefaultCellStyle.Format = "C2"; // C2 = formato de moneda con 2 decimales
            }
            if (dgvOrdenes.Columns["TotalRepuestos"] != null)
            {
                dgvOrdenes.Columns["TotalRepuestos"].HeaderText = "Total Repuestos";
                dgvOrdenes.Columns["TotalRepuestos"].DefaultCellStyle.Format = "C2";
            }
            if (dgvOrdenes.Columns["Total"] != null)
            {
                dgvOrdenes.Columns["Total"].HeaderText = "Total Orden";
                dgvOrdenes.Columns["Total"].DefaultCellStyle.Format = "C2";
            }
        } 

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var ordenActual = (OrdenServicioEntity)dgvOrdenes.CurrentRow.DataBoundItem;

                _ordenBss.CerrarOrden(ordenActual);

                MessageBox.Show($"Orden #{ordenActual.IdOrden} finalizada con éxito.");

                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Negocio / Rollback",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var ordenActual = (OrdenServicioEntity)dgvOrdenes.CurrentRow.DataBoundItem;

                _ordenBss.AnularOrden(ordenActual); 

                MessageBox.Show($"Orden #{ordenActual.IdOrden} anulada con éxito.");
                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Negocio (RN4)",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirYEsperar(this, new CrearOrden(this));
            this.CargarOrdenes();
        }
    }
}