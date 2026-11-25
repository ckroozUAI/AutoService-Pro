using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ClientesVehiculosForm : Form
    {
        private ClienteBss clienteBss = new ClienteBss();
        private VehiculoBss vehiculoBss = new VehiculoBss();

        private int clienteId, vehiculoId;
        private bool cargandoClientes, cargandoVehiculos;

        public ClientesVehiculosForm()
        {
            InitializeComponent();
        }

        private void ClientesVehiculosForm_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        

        private void CargarClientes(int seleccionarId = 0)
        {
            cargandoClientes = true;
            try
            {
                dgvClientes.DataSource = clienteBss.getAll();
                OcultarColumnas(dgvClientes, "Id", "FechaRegistro");
                if (dgvClientes.Columns["Dni"] != null) dgvClientes.Columns["Dni"]!.HeaderText = "DNI";
                if (dgvClientes.Columns["Telefono"] != null) dgvClientes.Columns["Telefono"]!.HeaderText = "Teléfono";
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            finally
            {
                cargandoClientes = false;
            }

            if (seleccionarId > 0 && Seleccionar<ClienteEntity>(dgvClientes, seleccionarId, c => c.Id, "Nombre"))
                ClienteSeleccionado();
            else
                NuevoCliente();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            ClienteSeleccionado();
        }

        private void ClienteSeleccionado()
        {
            if (cargandoClientes) return;
            if (dgvClientes.CurrentRow?.DataBoundItem is not ClienteEntity c) return;

            clienteId = c.Id;
            txtNombre.Text = c.Nombre;
            txtApellido.Text = c.Apellido;
            txtDni.Text = c.Dni;
            txtTelefono.Text = c.Telefono;
            txtEmail.Text = c.Email;

            gbVehiculos.Enabled = true;
            CargarVehiculos();
        }

        private void NuevoCliente()
        {
            clienteId = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dgvClientes.CurrentCell = null;
            dgvClientes.ClearSelection();

            dgvVehiculos.DataSource = null;
            gbVehiculos.Enabled = false;
            NuevoVehiculo();
            txtNombre.Focus();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = new ClienteEntity
                {
                    Id = clienteId,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDni.Text,
                    Telefono = Nulo(txtTelefono.Text),
                    Email = Nulo(txtEmail.Text)
                };
                clienteBss.save(entity);
                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes(entity.Id);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Confirmar("¿Eliminar el cliente seleccionado?")) return;

            try
            {
                clienteBss.delete(clienteId);
                CargarClientes();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }


        private void CargarVehiculos(int seleccionarId = 0)
        {
            cargandoVehiculos = true;
            try
            {
                dgvVehiculos.DataSource = vehiculoBss.getByCliente(clienteId);
                OcultarColumnas(dgvVehiculos, "Id", "IdCliente", "FechaRegistro");
                if (dgvVehiculos.Columns["Anio"] != null) dgvVehiculos.Columns["Anio"]!.HeaderText = "Año";
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            finally
            {
                cargandoVehiculos = false;
            }

            if (seleccionarId > 0 && Seleccionar<VehiculoEntity>(dgvVehiculos, seleccionarId, v => v.Id, "Patente"))
                VehiculoSeleccionado();
            else
                NuevoVehiculo();
        }

        private void dgvVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            VehiculoSeleccionado();
        }

        private void VehiculoSeleccionado()
        {
            if (cargandoVehiculos) return;
            if (dgvVehiculos.CurrentRow?.DataBoundItem is not VehiculoEntity v) return;

            vehiculoId = v.Id;
            txtPatente.Text = v.Patente;
            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            numAnio.Value = Math.Clamp(v.Anio, (int)numAnio.Minimum, (int)numAnio.Maximum);
            txtColor.Text = v.Color;
        }

        private void NuevoVehiculo()
        {
            vehiculoId = 0;
            txtPatente.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            numAnio.Value = Math.Min(DateTime.Now.Year, (int)numAnio.Maximum);
            dgvVehiculos.CurrentCell = null;
            dgvVehiculos.ClearSelection();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            NuevoVehiculo();
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Primero guarde o seleccione un cliente.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var entity = new VehiculoEntity
                {
                    Id = vehiculoId,
                    IdCliente = clienteId,
                    Patente = txtPatente.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Anio = (int)numAnio.Value,
                    Color = Nulo(txtColor.Text)
                };
                vehiculoBss.save(entity);
                MessageBox.Show("Vehículo guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVehiculos(entity.Id);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (vehiculoId == 0)
            {
                MessageBox.Show("Por favor, seleccione un vehículo de la lista.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Confirmar("¿Eliminar el vehículo seleccionado?")) return;

            try
            {
                vehiculoBss.delete(vehiculoId);
                CargarVehiculos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }


        private static void OcultarColumnas(DataGridView grid, params string[] columnas)
        {
            foreach (var c in columnas)
                if (grid.Columns[c] != null) grid.Columns[c]!.Visible = false;
        }

        private static bool Seleccionar<T>(DataGridView grid, int id, Func<T, int> getId, string columna)
        {
            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (fila.DataBoundItem is T item && getId(item) == id)
                {
                    grid.CurrentCell = fila.Cells[columna];
                    return true;
                }
            }
            return false;
        }

        private static string? Nulo(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? null : texto.Trim();
        }

        private bool Confirmar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmar",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
