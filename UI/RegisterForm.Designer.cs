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
            txtUsuario.Location = new Point(144, 33);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(30, 154);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 30);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Guardar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(170, 154);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 33);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 73);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 112);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Repetir contraseña:";
            label1.Click += label1_Click;
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(144, 109);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.Size = new Size(150, 23);
            txtRepetirPassword.TabIndex = 5;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 214);
            Controls.Add(txtRepetirPassword);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuario";
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