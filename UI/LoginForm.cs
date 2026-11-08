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
    public partial class LoginForm : Form
    {
        private UsuarioBss bss = new UsuarioBss();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("¡Inicio de sesión exitoso! Bienvenido.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegisterForm registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
            this.Show();
        }
        private bool ValidarCredenciales(string usuario, string password)
        {
            try
            {
                var entity = new UsuarioEntity
                {
                    Usuario = usuario,
                    Password = password
                };
                bss.login(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
