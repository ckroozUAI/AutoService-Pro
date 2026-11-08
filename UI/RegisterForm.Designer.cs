namespace UI
{
    partial class RegisterForm
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
            btnRegistrar = new Button();
            btnVolver = new Button();
            lblUsuario = new Label();
            lblPassword = new Label();
            label1 = new Label();
            txtRepetirPassword = new TextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(165, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 25);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(171, 25);
            txtPassword.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuBar;
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegistrar.Location = new Point(34, 175);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(114, 34);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Guardar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuBar;
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnVolver.Location = new Point(194, 175);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 34);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblUsuario.Location = new Point(34, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 17);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPassword.Location = new Point(34, 83);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 17);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(34, 127);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 4;
            label1.Text = "Repetir contraseña:";
            label1.Click += label1_Click;
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(165, 124);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.Size = new Size(171, 25);
            txtRepetirPassword.TabIndex = 5;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(365, 243);
            Controls.Add(txtRepetirPassword);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuario";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnRegistrar;
        private Button btnVolver;
        private Label lblUsuario;
        private Label lblPassword;
        private Label label1;
        private TextBox txtRepetirPassword;
    }
}