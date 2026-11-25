using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class RepuestosForm : Form
    {
        private RepuestoBss repuestoBss = new RepuestoBss();

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
                dgvRepuestos.DataSource = null;
                dgvRepuestos.DataSource = repuestoBss.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar repuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var repuesto = new RepuestoEntity
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = numPrecio.Value,
                    StockFisico = (int)numStock.Value
                };

                repuestoBss.create(repuesto);
                MessageBox.Show("Repuesto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            txtCodigo.Focus();
        }
    }
}