using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Entities;

namespace UI
{
    public partial class RepuestosForm : Form
    {
        // Instancia de la capa de negocio
        private RepuestoBss bss = new RepuestoBss();

        public RepuestosForm()
        {
            InitializeComponent();
        }

        private void RepuestosForm_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                // --- 1. AGREGAMOS ESTE BLOQUE PARA CREAR LAS COLUMNAS SI NO EXISTEN ---
                if (dgvRepuestos.Columns.Count == 0)
                {
                    dgvRepuestos.Columns.Add("Codigo", "Código");
                    dgvRepuestos.Columns.Add("Descripcion", "Descripción");
                    dgvRepuestos.Columns.Add("Precio", "Precio");
                    dgvRepuestos.Columns.Add("StockFisico", "Stock Físico");
                }
                // ----------------------------------------------------------------------

                // 2. Limpiamos las filas viejas (no las columnas)
                dgvRepuestos.Rows.Clear();

                // 3. Traemos los datos de la BLL
                List<RepuestoEntity> lista = bss.ObtenerTodos();

                foreach (var repuesto in lista)
                {
                    dgvRepuestos.Rows.Add(repuesto.Codigo, repuesto.Descripcion, repuesto.Precio, repuesto.StockFisico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;

            // Devuelve el cursor al primer cuadro de texto
            txtCodigo.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Validamos que no falten datos básicos
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete el código y la descripción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Armamos la entidad con los datos de la pantalla
                RepuestoEntity nuevoRepuesto = new RepuestoEntity();
                nuevoRepuesto.Codigo = txtCodigo.Text;
                nuevoRepuesto.Descripcion = txtDescripcion.Text;
                nuevoRepuesto.Precio = numPrecio.Value;
                nuevoRepuesto.StockFisico = (int)numStock.Value;

                // 3. Enviamos a la capa BLL para que aplique reglas y guarde en SQL
                bss.RegistrarNuevoRepuesto(nuevoRepuesto);

                // 4. Lo agregamos visualmente a la grilla para que el usuario lo vea
                dgvRepuestos.Rows.Add(nuevoRepuesto.Codigo, nuevoRepuesto.Descripcion, nuevoRepuesto.Precio, nuevoRepuesto.StockFisico);

                // 5. Limpiamos las cajas para el siguiente registro
                LimpiarCampos();

                MessageBox.Show("Repuesto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}