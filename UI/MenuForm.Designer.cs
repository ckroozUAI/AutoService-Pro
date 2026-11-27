namespace UI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnRepuestos = new Button();
            btnOrdenes = new Button();
            btnClientesVehiculos = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRepuestos
            // 
            btnRepuestos.Location = new Point(511, 63);
            btnRepuestos.Name = "btnRepuestos";
            btnRepuestos.Size = new Size(263, 53);
            btnRepuestos.TabIndex = 0;
            btnRepuestos.Text = "Repuestos";
            btnRepuestos.UseVisualStyleBackColor = true;
            btnRepuestos.Click += btnRepuestos_Click_1;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(511, 149);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(263, 53);
            btnOrdenes.TabIndex = 1;
            btnOrdenes.Text = "Ordenes de Trabajo";
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // btnClientesVehiculos
            // 
            btnClientesVehiculos.Location = new Point(511, 252);
            btnClientesVehiculos.Name = "btnClientesVehiculos";
            btnClientesVehiculos.Size = new Size(263, 53);
            btnClientesVehiculos.TabIndex = 2;
            btnClientesVehiculos.Text = "Clientes/Vehiculos";
            btnClientesVehiculos.UseVisualStyleBackColor = true;
            btnClientesVehiculos.Click += btnClientesVehiculos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 415);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 4;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientesVehiculos);
            Controls.Add(btnOrdenes);
            Controls.Add(btnRepuestos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRepuestos;
        private Button btnOrdenes;
        private Button btnClientesVehiculos;
        private PictureBox pictureBox1;
        private Button button1;
    }
}