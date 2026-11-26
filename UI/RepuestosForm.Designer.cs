namespace UI
{
    partial class RepuestosForm
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
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            numPrecio = new NumericUpDown();
            Label = new Label();
            label1 = new Label();
            label2 = new Label();
            numStock = new NumericUpDown();
            label3 = new Label();
            dgvRepuestos = new DataGridView();
            btnLimpiar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(112, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 41);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 159);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(112, 70);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 3;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(12, 15);
            Label.Name = "Label";
            Label.Size = new Size(46, 15);
            Label.TabIndex = 4;
            Label.Text = "Codigo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            // 
            // numStock
            // 
            numStock.Location = new Point(112, 99);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Stock";
            // 
            // dgvRepuestos
            // 
            dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepuestos.Location = new Point(289, 15);
            dgvRepuestos.Name = "dgvRepuestos";
            dgvRepuestos.Size = new Size(435, 332);
            dgvRepuestos.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(116, 159);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(28, 409);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(98, 23);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // RepuestosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvRepuestos);
            Controls.Add(label3);
            Controls.Add(numStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Label);
            Controls.Add(numPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Name = "RepuestosForm";
            Text = "RepuestosForm";
            Load += RepuestosForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private NumericUpDown numPrecio;
        private Label Label;
        private Label label1;
        private Label label2;
        private NumericUpDown numStock;
        private Label label3;
        private DataGridView dgvRepuestos;
        private Button btnLimpiar;
        private Button btnMenu;
    }
}