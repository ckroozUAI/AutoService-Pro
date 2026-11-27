
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.BackgroundColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(19, 29, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.EnableHeadersVisualStyles = false;
            dgvOrdenes.Location = new Point(14, 16);
            dgvOrdenes.Margin = new Padding(3, 4, 3, 4);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersVisible = false;
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(1368, 431);
            dgvOrdenes.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(262, 467);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(186, 52);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(473, 467);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(213, 52);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Anular";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(968, 467);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(181, 52);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Volver al Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(715, 467);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(213, 52);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Nueva Orden";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // GestionOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 544);
            Controls.Add(btnGenerar);
            Controls.Add(btnMenu);
            Controls.Add(btnEliminar);
            Controls.Add(btnFinalizar);
            Controls.Add(dgvOrdenes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionOrdenesForm";
            Text = "AutoService Pro - Gestión de Órdenes de Trabajo";
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