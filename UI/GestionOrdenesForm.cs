using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class GestionOrdenesForm : Form
    {
        private OrdenServicioBss ordenBss = new OrdenServicioBss();

        public GestionOrdenesForm()
        {
            InitializeComponent();
        }

        private void GestionOrdenesForm_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgvOrdenes.DataSource = null;
                dgvOrdenes.DataSource = ordenBss.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar órdenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var orden = (OrdenServicioEntity)dgvOrdenes.CurrentRow.DataBoundItem;
                ordenBss.finalizarOrden(orden.IdOrden);

                MessageBox.Show("Orden finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación RN3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var orden = (OrdenServicioEntity)dgvOrdenes.CurrentRow.DataBoundItem;
                ordenBss.eliminarOrden(orden.IdOrden);

                MessageBox.Show("Orden eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación RN4", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}