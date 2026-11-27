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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            txtCodigo.Location = new Point(128, 16);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 55);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(114, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 212);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 31);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(128, 93);
            numPrecio.Margin = new Padding(3, 4, 3, 4);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(137, 27);
            numPrecio.TabIndex = 3;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(14, 20);
            Label.Name = "Label";
            Label.Size = new Size(61, 20);
            Label.TabIndex = 4;
            Label.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 59);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Precio ($):";
            // 
            // numStock
            // 
            numStock.Location = new Point(128, 132);
            numStock.Margin = new Padding(3, 4, 3, 4);
            numStock.Name = "numStock";
            numStock.Size = new Size(137, 27);
            numStock.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Stock Físico:";
            // 
            // dgvRepuestos
            // 
            dgvRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRepuestos.BackgroundColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 29, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRepuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepuestos.EnableHeadersVisualStyles = false;
            dgvRepuestos.Location = new Point(334, 20);
            dgvRepuestos.Margin = new Padding(3, 4, 3, 4);
            dgvRepuestos.Name = "dgvRepuestos";
            dgvRepuestos.RowHeadersVisible = false;
            dgvRepuestos.RowHeadersWidth = 51;
            dgvRepuestos.Size = new Size(648, 395);
            dgvRepuestos.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(133, 212);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 31);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(42, 278);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(171, 31);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Volver al Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // RepuestosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 444);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "RepuestosForm";
            Text = "AutoService Pro - Gestión de Repuestos";
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