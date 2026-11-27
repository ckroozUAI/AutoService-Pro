using DAL.Models;
using Entities;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using UI;

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

        public void InsertarOrden(OrdenServicioEntity orden)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model =Mapper.OrdenServicioMapper.ToModel(orden);

                    dbContext.OrdenServicio.Add(model);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex) {
                throw ex;
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

        public List<OrdenServicioEntity> getAll()
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    return dbContext.OrdenServicio
                        .Select(m => OrdenServicioMapper.ToEntity(m))
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public OrdenServicioEntity getById(int idOrden)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.OrdenServicio.FirstOrDefault(o => o.IdOrden == idOrden);
                    return OrdenServicioMapper.ToEntity(model);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void finalizarOrden(int idOrden)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.OrdenServicio.FirstOrDefault(o => o.IdOrden == idOrden);
                    if (model == null) throw new Exception("No se encontró la orden de servicio.");

                    model.Estado = EstadosOrdenes.Finalizada;
                    model.FechaCierre = DateTime.Now;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AnularOrden(int idOrden)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.OrdenServicio.FirstOrDefault(o => o.IdOrden == idOrden);
                    if (model == null) throw new Exception("No se encontró la orden de servicio.");

                    model.Estado = EstadosOrdenes.Anulada;
                    model.FechaCierre = DateTime.Now;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void delete(int idOrden)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.OrdenServicio.FirstOrDefault(o => o.IdOrden == idOrden);
                    if (model == null) throw new Exception("No se encontró la orden de servicio.");

                    dbContext.OrdenServicio.Remove(model);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}