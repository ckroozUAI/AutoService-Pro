using BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class GestionOrdenesForm : Form
    {
        public GestionOrdenesForm()
        {
            InitializeComponent();
        }

        private void GestionOrdenesForm_Load(object sender, EventArgs e)
        {
            // Acá iría la carga de la grilla cuando Emanuel/Adrián terminen el OrdenDao
            // dgvOrdenes.DataSource = nueva OrdenBss().ObtenerTodas();
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            // Verificamos que el usuario haya seleccionado una orden en la grilla
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtenemos el objeto de la fila seleccionada
                var ordenActual = (OrdenTrabajoEntity)dgvOrdenes.CurrentRow.DataBoundItem;

                OrdenBss bss = new OrdenBss();
                bss.CerrarOrden(ordenActual); // Acá el BLL evalúa la RN3

                MessageBox.Show("La orden fue cerrada y finalizada con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver a cargar la grilla para refrescar los estados
                // dgvOrdenes.DataSource = bss.ObtenerTodas();
            }
            catch (Exception ex)
            {
                // Si la RN3 falla en la BLL, el mensaje de error cae acá
                MessageBox.Show(ex.Message, "Validación de Negocio",
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

                OrdenBss bss = new OrdenBss();
                bss.AnularOrden(ordenActual); // Acá el BLL evalúa la RN4

                MessageBox.Show("La orden fue anulada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // dgvOrdenes.DataSource = bss.ObtenerTodas();
            }
            catch (Exception ex)
            {
                // Si la RN4 falla en la BLL, el mensaje de error cae acá
                MessageBox.Show(ex.Message, "Validación de Negocio",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}