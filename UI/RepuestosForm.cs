using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class RepuestosForm : Form
    {
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
                dgvRepuestos.DataSource = bss.ObtenerTodos();

                if (dgvRepuestos.Columns["Id"] != null)
                {
                    dgvRepuestos.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los repuestos: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete el código y la descripción.", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var entity = new RepuestoEntity
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = numPrecio.Value,
                    StockFisico = (int)numStock.Value
                };
                bss.RegistrarNuevoRepuesto(entity);

                MessageBox.Show("Repuesto registrado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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