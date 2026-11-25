namespace UI
{
    partial class GestionOrdenesForm
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
            dgvOrdenes = new DataGridView();
            btnCerrarOrden = new Button();
            btnAnularOrden = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(12, 12);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.Size = new Size(556, 253);
            dgvOrdenes.TabIndex = 0;
            // 
            // btnCerrarOrden
            // 
            btnCerrarOrden.Location = new Point(83, 325);
            btnCerrarOrden.Name = "btnCerrarOrden";
            btnCerrarOrden.Size = new Size(164, 23);
            btnCerrarOrden.TabIndex = 1;
            btnCerrarOrden.Text = "Finalizar Orden";
            btnCerrarOrden.UseVisualStyleBackColor = true;
            btnCerrarOrden.Click += btnCerrarOrden_Click;
            // 
            // btnAnularOrden
            // 
            btnAnularOrden.Location = new Point(321, 325);
            btnAnularOrden.Name = "btnAnularOrden";
            btnAnularOrden.Size = new Size(164, 23);
            btnAnularOrden.TabIndex = 2;
            btnAnularOrden.Text = "Anular Orden";
            btnAnularOrden.UseVisualStyleBackColor = true;
            btnAnularOrden.Click += btnAnularOrden_Click;
            // 
            // GestionOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 384);
            Controls.Add(btnAnularOrden);
            Controls.Add(btnCerrarOrden);
            Controls.Add(dgvOrdenes);
            Name = "GestionOrdenesForm";
            Text = "GestionOrdenesForm";
            Load += GestionOrdenesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrdenes;
        private Button btnCerrarOrden;
        private Button btnAnularOrden;
    }
}