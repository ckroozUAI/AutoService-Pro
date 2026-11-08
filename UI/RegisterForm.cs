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
using System.Windows.Forms;

namespace UI
{
    public partial class RegisterForm : Form
    {
        private UsuarioBss bss= new UsuarioBss();
        public RegisterForm()
        {
            InitializeComponent();
        }
         private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Por favor completa todos los campos.", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRepetirPassword.Text) || !(txtRepetirPassword.Text.Equals(txtPassword.Text)))
                {
                    MessageBox.Show("Las constraseñas no coinciden.", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool registroExitoso = RegistrarNuevoUsuario(txtUsuario.Text, txtPassword.Text);

                if (registroExitoso)
                {
                    MessageBox.Show("Usuario registrado con éxito. Serás redirigido al login.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo completar el registro.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void btnVolver_Click(object sender, EventArgs e)
        {
             this.Close();
        }

         private bool RegistrarNuevoUsuario(string usuario, string password)
        {
            try
            {
                var entity = new UsuarioEntity { 
                    
                    Usuario = usuario,
                    Password = password
                };
                bss.create(entity);
                return true;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
