using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class RepuestosForm : Form
    {
        private RepuestoBss repuestoBss = new RepuestoBss();
        private readonly Form _menuForm;

        public RepuestosForm(Form menuForm)
        {
            InitializeComponent();
            _menuForm = menuForm;

            TemaUI.AplicarTemaFormulario(this);
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
                dgvRepuestos.DataSource = repuestoBss.ObtenerTodos();
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

                repuestoBss.RegistrarNuevoRepuesto(repuesto);
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            NavegacionHelper.VolverAMenu(this, _menuForm);
        }
    }
}