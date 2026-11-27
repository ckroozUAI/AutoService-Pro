using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace UI
{
    public partial class CrearOrden : Form
    {
        private OrdenBss bss = new OrdenBss();
        private RepuestoBss repuestosBss = new RepuestoBss();         
        private Decimal totalRepuestos = 0;
        private int cantidadtotalRepuestos = 0;
        private readonly Form _menuForm;
        private OrdenServicioEntity orden = new OrdenServicioEntity();
        public CrearOrden(Form menuForm)
        {
            InitializeComponent();
            _menuForm = new Form();

            TemaUI.AplicarTemaFormulario(this);
        }

        private void CrearOrden_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
             
            try
            {
                if (int.TryParse(txtIdVehiculo.Text, out int idVehiculo))
                {
                    orden.IdVehiculo = idVehiculo;
                }
                else
                {
                    throw new Exception("El id de vehiculo debe ser numerico.");
                }

                if (int.TryParse(txtKilometraje.Text, out int kilometraje))
                {
                    if (Convert.ToInt32(txtKilometraje.Text) <= 0) throw new Exception("El kilometraje de vehiculo debe ser mayor a cero.");
                    orden.Kilometraje = kilometraje;
                }
                else
                {
                    throw new Exception("El kilometraje de vehiculo debe ser numerico.");
                }
                if (decimal.TryParse(txtManoObra.Text, out decimal manoObra) || Convert.ToDecimal(txtKilometraje.Text) <= 0)
                {
                    if (Convert.ToInt32(txtManoObra.Text) <= 0) throw new Exception("El monto de mano de obra debe ser mayor a cero");
                    orden.ManoObra = manoObra;
                }
                else
                {
                    throw new Exception("El monto de mano de obra debe ser numerico y mayor a cero.");
                }
                orden.IdTecnico = comboBox1.SelectedIndex;
                orden.FechaCierre = dateTimePicker1.Value;
                orden.Total =orden.ManoObra+ this.totalRepuestos;
                orden.TotalRepuestos = this.totalRepuestos;
                bss.CrearOrden(orden);
                MessageBox.Show("Orden genreada con exito.");
                this.clean();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblTotalOrden_Click(object sender, EventArgs e)
        {

        }

        public void clean()
        {
            txtIdVehiculo.Text = "";
            txtIdRepuesto.Text = "";
            txtKilometraje.Text = "";
            txtManoObra.Text = "";
            this.totalRepuestos = 0;
            this.cantidadtotalRepuestos = 0;
            this.lblTotalMontoRepuestos.Text = "";
            this.lblTotalRepuestos.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdRepuesto.Text, out int idRepuesto)) throw new Exception("Ingrese un ID de repuesto valido.");
                var repuesto = repuestosBss.getById(idRepuesto);
                repuesto.StockFisico = repuesto.StockFisico - 1;
                repuestosBss.DescontarRepuesto(repuesto);
                this.totalRepuestos += repuesto.Precio;
                this.cantidadtotalRepuestos++;
                this.lblTotalMontoRepuestos.Text = this.totalRepuestos.ToString();
                this.lblTotalRepuestos.Text = cantidadtotalRepuestos.ToString(); 
                
                MessageBox.Show("Repuesto agregado a la orden con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblTotalMontoRepuestos_Click(object sender, EventArgs e)
        {

        }
    }
}
