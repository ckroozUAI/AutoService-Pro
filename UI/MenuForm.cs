using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirYEsperar(this, new RepuestosForm(this));
        }


        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnRepuestos_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirYEsperar(this, new RepuestosForm(this));
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirYEsperar(this, new GestionOrdenesForm(this));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientesVehiculos_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirYEsperar(this, new ClientesVehiculosForm(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
