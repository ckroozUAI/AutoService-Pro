using Entities;
using Microsoft.Data.SqlClient;
using System;

namespace DAL
{
    public class OrdenDao
    {
        public int ObtenerUltimoKilometraje(int idVehiculo)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = @"
                    SELECT ISNULL(
                        (SELECT MAX(KILOMETRAJE_INGRESO) FROM OrdenServicio WHERE ID_VEHICULO = @IdVehiculo),
                        (SELECT ISNULL(KILOMETRAJE, 0) FROM Vehiculo WHERE ID = @IdVehiculo)
                    )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public int ObtenerStockActual(int idRepuesto)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = "SELECT STOCK_FISICO FROM Repuesto WHERE ID = @IdRepuesto";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRepuesto", idRepuesto);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        throw new Exception($"El repuesto con ID {idRepuesto} no existe.");

                    return Convert.ToInt32(result);
                }
            }
        }

        public int InsertarOrden(OrdenTrabajoEntity orden)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = @"
                    INSERT INTO OrdenServicio 
                        (ID_VEHICULO, FECHA_INGRESO, FECHA_CIERRE, KILOMETRAJE_INGRESO, DIAGNOSTICO, ESTADO, MANO_OBRA, IMPUESTOS, TOTAL)
                    OUTPUT INSERTED.ID
                    VALUES 
                        (@IdVehiculo, @FechaIngreso, @FechaCierre, @Kilometraje, @Diagnostico, @Estado, @ManoObra, @Impuestos, @Total)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdVehiculo", orden.IdVehiculo);
                    cmd.Parameters.AddWithValue("@FechaIngreso", orden.FechaIngreso);
                    cmd.Parameters.AddWithValue("@FechaCierre", (object)orden.FechaCierre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Kilometraje", orden.KilometrajeIngreso);
                    cmd.Parameters.AddWithValue("@Diagnostico", (object)orden.Diagnostico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado", orden.Estado);
                    cmd.Parameters.AddWithValue("@ManoObra", orden.ManoObra);
                    cmd.Parameters.AddWithValue("@Impuestos", orden.Impuestos);
                    cmd.Parameters.AddWithValue("@Total", orden.CostoTotal);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void InsertarDetalle(DetalleOrdenEntity detalle)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = @"
                    INSERT INTO DetalleOrden (ID_ORDEN, ID_REPUESTO, CANTIDAD, PRECIO_UNITARIO)
                    VALUES (@IdOrden, @IdRepuesto, @Cantidad, @PrecioUnitario)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdOrden", detalle.IdOrden);
                    cmd.Parameters.AddWithValue("@IdRepuesto", detalle.IdRepuesto);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DescontarStock(int idRepuesto, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = @"
                    UPDATE Repuesto 
                    SET STOCK_FISICO = STOCK_FISICO - @Cantidad 
                    WHERE ID = @IdRepuesto AND STOCK_FISICO >= @Cantidad";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdRepuesto", idRepuesto);
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0)
                        throw new Exception($"Stock insuficiente para descontar {cantidad} unidades del repuesto ID {idRepuesto}.");
                }
            }
        }

        public void ActualizarKilometrajeVehiculo(int idVehiculo, int nuevoKilometraje)
        {
            using (SqlConnection conn = new SqlConnection(ConeccionString.getConectionString()))
            {
                string query = "UPDATE Vehiculo SET KILOMETRAJE = @Kilometraje WHERE ID = @IdVehiculo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kilometraje", nuevoKilometraje);
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}