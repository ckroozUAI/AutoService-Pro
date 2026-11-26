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
            btnRepuestos = new Button();
            btnOrdenes = new Button();
            btnClientesVehiculos = new Button();
            SuspendLayout();
            // 
            // btnRepuestos
            // 
            btnRepuestos.Location = new Point(485, 27);
            btnRepuestos.Name = "btnRepuestos";
            btnRepuestos.Size = new Size(263, 53);
            btnRepuestos.TabIndex = 0;
            btnRepuestos.Text = "Repuestos";
            btnRepuestos.UseVisualStyleBackColor = true;
            btnRepuestos.Click += btnRepuestos_Click_1;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(485, 103);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(263, 53);
            btnOrdenes.TabIndex = 1;
            btnOrdenes.Text = "Ordenes de compra";
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // btnClientesVehiculos
            // 
            btnClientesVehiculos.Location = new Point(485, 194);
            btnClientesVehiculos.Name = "btnClientesVehiculos";
            btnClientesVehiculos.Size = new Size(263, 53);
            btnClientesVehiculos.TabIndex = 2;
            btnClientesVehiculos.Text = "Clientes/Vehiculos";
            btnClientesVehiculos.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClientesVehiculos);
            Controls.Add(btnOrdenes);
            Controls.Add(btnRepuestos);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRepuestos;
        private Button btnOrdenes;
        private Button btnClientesVehiculos;
    }
}