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
            gbClientes.Location = new Point(12, 12);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(956, 300);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            gbClientes.Text = "Clientes";
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(824, 24);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(120, 23);
            btnVolverMenu.TabIndex = 15;
            btnVolverMenu.Text = "Volver al Menu";
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
            dgvClientes.Location = new Point(12, 118);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(932, 170);
            dgvClientes.TabIndex = 10;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(212, 78);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(90, 28);
            btnEliminarCliente.TabIndex = 7;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(112, 78);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(90, 28);
            btnGuardarCliente.TabIndex = 6;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(12, 78);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(90, 28);
            btnNuevoCliente.TabIndex = 5;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(552, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(552, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(412, 42);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(412, 24);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(292, 42);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(110, 23);
            txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(292, 24);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 12;
            lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(152, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(152, 24);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // gbVehiculos
            // 
            gbVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            gbVehiculos.Location = new Point(12, 322);
            gbVehiculos.Name = "gbVehiculos";
            gbVehiculos.Size = new Size(956, 331);
            gbVehiculos.TabIndex = 1;
            gbVehiculos.TabStop = false;
            gbVehiculos.Text = "Vehículos del cliente seleccionado";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculos.BackgroundColor = SystemColors.Window;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(12, 118);
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersVisible = false;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(932, 201);
            dgvVehiculos.TabIndex = 10;
            dgvVehiculos.SelectionChanged += dgvVehiculos_SelectionChanged;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(212, 78);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(90, 28);
            btnEliminarVehiculo.TabIndex = 7;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            btnEliminarVehiculo.Click += btnEliminarVehiculo_Click;
            // 
            // btnGuardarVehiculo
            // 
            btnGuardarVehiculo.Location = new Point(112, 78);
            btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            btnGuardarVehiculo.Size = new Size(90, 28);
            btnGuardarVehiculo.TabIndex = 6;
            btnGuardarVehiculo.Text = "Guardar";
            btnGuardarVehiculo.UseVisualStyleBackColor = true;
            btnGuardarVehiculo.Click += btnGuardarVehiculo_Click;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.Location = new Point(12, 78);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Size = new Size(90, 28);
            btnNuevoVehiculo.TabIndex = 5;
            btnNuevoVehiculo.Text = "Nuevo";
            btnNuevoVehiculo.UseVisualStyleBackColor = true;
            btnNuevoVehiculo.Click += btnNuevoVehiculo_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(492, 42);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(110, 23);
            txtColor.TabIndex = 4;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(492, 24);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 14;
            lblColor.Text = "Color:";
            // 
            // numAnio
            // 
            numAnio.Location = new Point(402, 42);
            numAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numAnio.Name = "numAnio";
            numAnio.Size = new Size(80, 23);
            numAnio.TabIndex = 3;
            numAnio.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(402, 24);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(32, 15);
            lblAnio.TabIndex = 13;
            lblAnio.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(262, 42);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(130, 23);
            txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(262, 24);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(122, 42);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(130, 23);
            txtMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(122, 24);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(12, 42);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 0;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(12, 24);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 10;
            lblPatente.Text = "Patente:";
            // 
            // ClientesVehiculosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 665);
            Controls.Add(gbVehiculos);
            Controls.Add(gbClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(996, 704);
            Name = "ClientesVehiculosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM Clientes y Vehículos";
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
    }
}
