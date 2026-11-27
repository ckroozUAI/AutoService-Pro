namespace UI
{
    partial class ClientesVehiculosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesVehiculosForm));
            gbClientes = new GroupBox();
            btnVolverMenu = new Button();
            dgvClientes = new DataGridView();
            btnEliminarCliente = new Button();
            btnGuardarCliente = new Button();
            btnNuevoCliente = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbVehiculos = new GroupBox();
            txtKilometraje = new TextBox();
            lblKilometraje = new Label();
            dgvVehiculos = new DataGridView();
            btnEliminarVehiculo = new Button();
            btnGuardarVehiculo = new Button();
            btnNuevoVehiculo = new Button();
            txtColor = new TextBox();
            lblColor = new Label();
            numAnio = new NumericUpDown();
            lblAnio = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtPatente = new TextBox();
            lblPatente = new Label();
            gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnio).BeginInit();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbClientes.Controls.Add(btnVolverMenu);
            gbClientes.Controls.Add(dgvClientes);
            gbClientes.Controls.Add(btnEliminarCliente);
            gbClientes.Controls.Add(btnGuardarCliente);
            gbClientes.Controls.Add(btnNuevoCliente);
            gbClientes.Controls.Add(txtEmail);
            gbClientes.Controls.Add(lblEmail);
            gbClientes.Controls.Add(txtTelefono);
            gbClientes.Controls.Add(lblTelefono);
            gbClientes.Controls.Add(txtDni);
            gbClientes.Controls.Add(lblDni);
            gbClientes.Controls.Add(txtApellido);
            gbClientes.Controls.Add(lblApellido);
            gbClientes.Controls.Add(txtNombre);
            gbClientes.Controls.Add(lblNombre);
            gbClientes.Location = new Point(14, 16);
            gbClientes.Margin = new Padding(3, 4, 3, 4);
            gbClientes.Name = "gbClientes";
            gbClientes.Padding = new Padding(3, 4, 3, 4);
            gbClientes.Size = new Size(1093, 400);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            gbClientes.Text = "Clientes";
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(942, 32);
            btnVolverMenu.Margin = new Padding(3, 4, 3, 4);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(137, 31);
            btnVolverMenu.TabIndex = 15;
            btnVolverMenu.Text = "Volver al Menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click_1;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.Window;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(14, 157);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1065, 227);
            dgvClientes.TabIndex = 10;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(242, 104);
            btnEliminarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(103, 37);
            btnEliminarCliente.TabIndex = 7;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(128, 104);
            btnGuardarCliente.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(103, 37);
            btnGuardarCliente.TabIndex = 6;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(14, 104);
            btnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(103, 37);
            btnNuevoCliente.TabIndex = 5;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(631, 56);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(631, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(471, 56);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(148, 27);
            txtTelefono.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(471, 32);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(334, 56);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(334, 32);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 12;
            lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(174, 56);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(148, 27);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(174, 32);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 56);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 27);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // gbVehiculos
            // 
            gbVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbVehiculos.Controls.Add(txtKilometraje);
            gbVehiculos.Controls.Add(lblKilometraje);
            gbVehiculos.Controls.Add(dgvVehiculos);
            gbVehiculos.Controls.Add(btnEliminarVehiculo);
            gbVehiculos.Controls.Add(btnGuardarVehiculo);
            gbVehiculos.Controls.Add(btnNuevoVehiculo);
            gbVehiculos.Controls.Add(txtColor);
            gbVehiculos.Controls.Add(lblColor);
            gbVehiculos.Controls.Add(numAnio);
            gbVehiculos.Controls.Add(lblAnio);
            gbVehiculos.Controls.Add(txtModelo);
            gbVehiculos.Controls.Add(lblModelo);
            gbVehiculos.Controls.Add(txtMarca);
            gbVehiculos.Controls.Add(lblMarca);
            gbVehiculos.Controls.Add(txtPatente);
            gbVehiculos.Controls.Add(lblPatente);
            gbVehiculos.Location = new Point(14, 429);
            gbVehiculos.Margin = new Padding(3, 4, 3, 4);
            gbVehiculos.Name = "gbVehiculos";
            gbVehiculos.Padding = new Padding(3, 4, 3, 4);
            gbVehiculos.Size = new Size(1093, 441);
            gbVehiculos.TabIndex = 1;
            gbVehiculos.TabStop = false;
            gbVehiculos.Text = "Vehículos del cliente seleccionado";
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(703, 56);
            txtKilometraje.Margin = new Padding(3, 4, 3, 4);
            txtKilometraje.MaxLength = 7;
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(174, 27);
            txtKilometraje.TabIndex = 15;
            // 
            // lblKilometraje
            // 
            lblKilometraje.AutoSize = true;
            lblKilometraje.Location = new Point(703, 32);
            lblKilometraje.Name = "lblKilometraje";
            lblKilometraje.Size = new Size(89, 20);
            lblKilometraje.TabIndex = 16;
            lblKilometraje.Text = "Kilometraje:";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculos.BackgroundColor = SystemColors.Window;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(14, 157);
            dgvVehiculos.Margin = new Padding(3, 4, 3, 4);
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersVisible = false;
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(1065, 268);
            dgvVehiculos.TabIndex = 10;
            dgvVehiculos.SelectionChanged += dgvVehiculos_SelectionChanged;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(242, 104);
            btnEliminarVehiculo.Margin = new Padding(3, 4, 3, 4);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(103, 37);
            btnEliminarVehiculo.TabIndex = 7;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            btnEliminarVehiculo.Click += btnEliminarVehiculo_Click;
            // 
            // btnGuardarVehiculo
            // 
            btnGuardarVehiculo.Location = new Point(128, 104);
            btnGuardarVehiculo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            btnGuardarVehiculo.Size = new Size(103, 37);
            btnGuardarVehiculo.TabIndex = 6;
            btnGuardarVehiculo.Text = "Guardar";
            btnGuardarVehiculo.UseVisualStyleBackColor = true;
            btnGuardarVehiculo.Click += btnGuardarVehiculo_Click;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.Location = new Point(14, 104);
            btnNuevoVehiculo.Margin = new Padding(3, 4, 3, 4);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Size = new Size(103, 37);
            btnNuevoVehiculo.TabIndex = 5;
            btnNuevoVehiculo.Text = "Nuevo";
            btnNuevoVehiculo.UseVisualStyleBackColor = true;
            btnNuevoVehiculo.Click += btnNuevoVehiculo_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(562, 56);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 27);
            txtColor.TabIndex = 4;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(562, 32);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 14;
            lblColor.Text = "Color:";
            // 
            // numAnio
            // 
            numAnio.Location = new Point(459, 56);
            numAnio.Margin = new Padding(3, 4, 3, 4);
            numAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numAnio.Name = "numAnio";
            numAnio.Size = new Size(91, 27);
            numAnio.TabIndex = 3;
            numAnio.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(459, 32);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(39, 20);
            lblAnio.TabIndex = 13;
            lblAnio.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(299, 56);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(148, 27);
            txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(299, 32);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(139, 56);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(148, 27);
            txtMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(139, 32);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(14, 56);
            txtPatente.Margin = new Padding(3, 4, 3, 4);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(114, 27);
            txtPatente.TabIndex = 0;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(14, 32);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(61, 20);
            lblPatente.TabIndex = 10;
            lblPatente.Text = "Patente:";
            // 
            // ClientesVehiculosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 887);
            Controls.Add(gbVehiculos);
            Controls.Add(gbClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1136, 923);
            Name = "ClientesVehiculosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoService Pro - ABM de Clientes y Vehículos";
            Load += ClientesVehiculosForm_Load;
            gbClientes.ResumeLayout(false);
            gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbVehiculos.ResumeLayout(false);
            gbVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientes;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnNuevoCliente;
        private Button btnGuardarCliente;
        private Button btnEliminarCliente;
        private DataGridView dgvClientes;
        private GroupBox gbVehiculos;
        private Label lblPatente;
        private TextBox txtPatente;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label lblAnio;
        private NumericUpDown numAnio;
        private Label lblColor;
        private TextBox txtColor;
        private Button btnNuevoVehiculo;
        private Button btnGuardarVehiculo;
        private Button btnEliminarVehiculo;
        private DataGridView dgvVehiculos;
        private Button btnVolverMenu;
        private TextBox txtKilometraje;
        private Label lblKilometraje;
    }
}
