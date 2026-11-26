using DAL.Models;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class OrdenServicioDao
    {
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

                    model.Estado = "Finalizada";
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