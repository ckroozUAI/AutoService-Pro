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
            btnRepuestos.BackColor = Color.FromArgb(0, 114, 198);
            btnRepuestos.Cursor = Cursors.Hand;
            btnRepuestos.FlatStyle = FlatStyle.Flat;
            btnRepuestos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRepuestos.ForeColor = Color.White;
            btnRepuestos.Location = new Point(484, 32);
            btnRepuestos.Margin = new Padding(3, 4, 3, 4);
            btnRepuestos.Name = "btnRepuestos";
            btnRepuestos.Size = new Size(301, 71);
            btnRepuestos.TabIndex = 0;
            btnRepuestos.Text = "Catálogo de Repuestos";
            btnRepuestos.UseVisualStyleBackColor = false;
            btnRepuestos.Click += btnRepuestos_Click_1;
            // 
            // btnOrdenes
            // 
            btnOrdenes.BackColor = Color.FromArgb(0, 114, 198);
            btnOrdenes.Cursor = Cursors.Hand;
            btnOrdenes.FlatStyle = FlatStyle.Flat;
            btnOrdenes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOrdenes.ForeColor = Color.White;
            btnOrdenes.Location = new Point(484, 128);
            btnOrdenes.Margin = new Padding(3, 4, 3, 4);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(301, 71);
            btnOrdenes.TabIndex = 1;
            btnOrdenes.Text = "Órdenes de Trabajo";
            btnOrdenes.UseVisualStyleBackColor = false;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // btnClientesVehiculos
            // 
            btnClientesVehiculos.BackColor = Color.FromArgb(0, 114, 198);
            btnClientesVehiculos.Cursor = Cursors.Hand;
            btnClientesVehiculos.FlatStyle = FlatStyle.Flat;
            btnClientesVehiculos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClientesVehiculos.ForeColor = Color.White;
            btnClientesVehiculos.Location = new Point(484, 224);
            btnClientesVehiculos.Margin = new Padding(3, 4, 3, 4);
            btnClientesVehiculos.Name = "btnClientesVehiculos";
            btnClientesVehiculos.Size = new Size(301, 71);
            btnClientesVehiculos.TabIndex = 2;
            btnClientesVehiculos.Text = "Clientes / Vehículos";
            btnClientesVehiculos.UseVisualStyleBackColor = false;
            btnClientesVehiculos.Click += btnClientesVehiculos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(536, 324);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(192, 31);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 382);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientesVehiculos);
            Controls.Add(btnOrdenes);
            Controls.Add(btnRepuestos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "AutoService Pro - Menú Principal";
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