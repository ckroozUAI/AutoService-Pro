namespace UI
{
    partial class CrearOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearOrden));
            label1 = new Label();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtIdRepuesto = new TextBox();
            lblTotalMontoRepuestos = new Label();
            lblTotalRepuestos = new Label();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            txtKilometraje = new TextBox();
            label9 = new Label();
            btnCrear = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtManoObra = new TextBox();
            txtIdVehiculo = new TextBox();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Vehículo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 100);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Técnico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Cierre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 193);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Mano de Obra ($):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 63);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "ID Repuesto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdRepuesto);
            groupBox1.Controls.Add(lblTotalMontoRepuestos);
            groupBox1.Controls.Add(lblTotalRepuestos);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(507, 71);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(353, 350);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asignación de Repuestos";
            // 
            // txtIdRepuesto
            // 
            txtIdRepuesto.Location = new Point(191, 63);
            txtIdRepuesto.Margin = new Padding(3, 4, 3, 4);
            txtIdRepuesto.Name = "txtIdRepuesto";
            txtIdRepuesto.Size = new Size(141, 27);
            txtIdRepuesto.TabIndex = 11;
            // 
            // lblTotalMontoRepuestos
            // 
            lblTotalMontoRepuestos.AutoSize = true;
            lblTotalMontoRepuestos.Location = new Point(191, 123);
            lblTotalMontoRepuestos.Name = "lblTotalMontoRepuestos";
            lblTotalMontoRepuestos.Size = new Size(17, 20);
            lblTotalMontoRepuestos.TabIndex = 10;
            lblTotalMontoRepuestos.Text = "0";
            lblTotalMontoRepuestos.Click += lblTotalMontoRepuestos_Click;
            // 
            // lblTotalRepuestos
            // 
            lblTotalRepuestos.AutoSize = true;
            lblTotalRepuestos.Location = new Point(191, 183);
            lblTotalRepuestos.Name = "lblTotalRepuestos";
            lblTotalRepuestos.Size = new Size(17, 20);
            lblTotalRepuestos.TabIndex = 9;
            lblTotalRepuestos.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(87, 278);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 48);
            button1.TabIndex = 8;
            button1.Text = "Agregar repuesto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 183);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 7;
            label8.Text = "Cantidad de Repuestos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 123);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 6;
            label7.Text = "Monto Total Repuestos:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKilometraje);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(txtManoObra);
            groupBox2.Controls.Add(txtIdVehiculo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(26, 71);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(416, 350);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nueva Orden";
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(166, 225);
            txtKilometraje.Margin = new Padding(3, 4, 3, 4);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(241, 27);
            txtKilometraje.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 236);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 17;
            label9.Text = "Kilometraje:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(115, 278);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(203, 49);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear orden";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(169, 100);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 137);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtManoObra
            // 
            txtManoObra.Location = new Point(168, 183);
            txtManoObra.Margin = new Padding(3, 4, 3, 4);
            txtManoObra.Name = "txtManoObra";
            txtManoObra.Size = new Size(241, 27);
            txtManoObra.TabIndex = 13;
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Location = new Point(168, 52);
            txtIdVehiculo.Margin = new Padding(3, 4, 3, 4);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(241, 27);
            txtIdVehiculo.TabIndex = 12;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(634, 16);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(226, 31);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver a Gestión de Órdenes";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // CrearOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 448);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearOrden";
            Text = "AutoService Pro - Crear Orden de Trabajo";
            Load += CrearOrden_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblTotalMontoRepuestos;
        private Label lblTotalRepuestos;
        private Button button1;
        private Label label8;
        private Label label7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtManoObra;
        private TextBox txtIdVehiculo;
        private TextBox txtIdRepuesto;
        private Button btnCrear;
        private TextBox txtKilometraje;
        private Label label9;
        private Button btnVolver;
    }
}