
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOrdenesForm));
            dgvOrdenes = new DataGridView();
            btnFinalizar = new Button();
            btnEliminar = new Button();
            btnMenu = new Button();
            btnGenerar = new Button();
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
            btnFinalizar.Location = new Point(12, 357);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(163, 39);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(197, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 39);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Anular";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(630, 357);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(158, 39);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(409, 357);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(186, 39);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar ";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // GestionOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerar);
            Controls.Add(btnMenu);
            Controls.Add(btnEliminar);
            Controls.Add(btnFinalizar);
            Controls.Add(dgvOrdenes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionOrdenesForm";
            Text = "Gestion de ordenes de trabajo";
            Load += GestionOrdenesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            NavegacionHelper.VolverAMenu(this, _menuForm);
        }

        #endregion

        private DataGridView dgvOrdenes;
        private Button btnFinalizar;
        private Button btnEliminar;
        private Button btnMenu;
        private Button btnGenerar;
    }
}