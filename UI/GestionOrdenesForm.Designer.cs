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
            btnFinalizar = new Button();
            btnEliminar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(12, 12);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.Size = new Size(776, 323);
            dgvOrdenes.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(12, 341);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(376, 60);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(432, 341);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(356, 60);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(351, 418);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(117, 23);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // GestionOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnEliminar);
            Controls.Add(btnFinalizar);
            Controls.Add(dgvOrdenes);
            Name = "GestionOrdenesForm";
            Text = "GestionOrdenesForm";
            Load += GestionOrdenesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrdenes;
        private Button btnFinalizar;
        private Button btnEliminar;
        private Button btnMenu;
    }
}