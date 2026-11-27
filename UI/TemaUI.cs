using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public static class TemaUI
    {
        // Paleta corporativa (Azul Marino, Acero, Verde y Rojo)
        public static readonly Color FondoFormulario = Color.FromArgb(241, 245, 249);
        public static readonly Color AzulOscuro = Color.FromArgb(15, 29, 48);
        public static readonly Color AzulAcento = Color.FromArgb(0, 114, 198);
        public static readonly Color VerdeAccion = Color.FromArgb(22, 163, 74);
        public static readonly Color RojoAccion = Color.FromArgb(220, 38, 38);
        public static readonly Color GrisNeutro = Color.FromArgb(71, 85, 105);
        public static readonly Color TextoOscuro = Color.FromArgb(30, 41, 59);

        public static void AplicarTemaFormulario(Form form)
        {
            form.BackColor = FondoFormulario;
            form.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;

            EstilizarControlesRecursivo(form.Controls);
        }

        private static void EstilizarControlesRecursivo(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is GroupBox gb)
                {
                    gb.BackColor = Color.White;
                    gb.ForeColor = AzulOscuro;
                    gb.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = TextoOscuro;
                    lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }
                else if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown || ctrl is DateTimePicker)
                {
                    ctrl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }
                else if (ctrl is Button btn)
                {
                    EstilizarBotonAutomatico(btn);
                }
                else if (ctrl is DataGridView dgv)
                {
                    EstilizarGrilla(dgv);
                }

                if (ctrl.HasChildren)
                {
                    EstilizarControlesRecursivo(ctrl.Controls);
                }
            }
        }

        public static void EstilizarBotonAutomatico(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            string texto = (btn.Text ?? "").Trim().ToLower();

            if (texto.Contains("guardar") || texto.Contains("crear") || texto.Contains("finalizar") ||
                texto.Contains("ingresar") || texto.Contains("registrar") || texto.Contains("agregar"))
            {
                btn.BackColor = VerdeAccion;
            }
            else if (texto.Contains("eliminar") || texto.Contains("anular") || texto.Contains("salir"))
            {
                btn.BackColor = RojoAccion;
            }
            else if (texto.Contains("volver") || texto.Contains("limpiar") || texto.Contains("nuevo"))
            {
                btn.BackColor = GrisNeutro;
            }
            else
            {
                btn.BackColor = AzulAcento;
            }
        }

        public static void EstilizarGrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = AzulOscuro;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 34;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = TextoOscuro;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = AzulOscuro;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.RowTemplate.Height = 28;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
