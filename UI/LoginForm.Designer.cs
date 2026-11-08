namespace UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(120, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.MenuBar;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIngresar.Location = new Point(30, 115);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 30);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.MenuBar;
            btnRegistrarse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarse.Location = new Point(170, 115);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(100, 30);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(30, 73);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 4;
            label1.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(30, 33);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(300, 175);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnRegistrarse;
        private Label label1;
        private Label label2;
    }
}