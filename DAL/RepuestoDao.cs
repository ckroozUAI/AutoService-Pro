using DAL.Models;
using Entities;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepuestoDao
    {
        public List<RepuestoEntity> getAll()
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    return dbContext.Repuesto.AsNoTracking()
                        .OrderBy(r => r.Descripcion)
                        .ToList()
                        .Select(RepuestoMapper.ToEntity)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public RepuestoEntity? getByCodigo(string codigo)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Repuesto.AsNoTracking().FirstOrDefault(r => r.Codigo == codigo);
                    return model == null ? null : RepuestoMapper.ToEntity(model);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public RepuestoEntity? getById(int id)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Repuesto.AsNoTracking().FirstOrDefault(r => r.Id == id);
                    return model == null ? null : RepuestoMapper.ToEntity(model);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void create(RepuestoEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = RepuestoMapper.ToModel(entity);
                    dbContext.Add(model);
                    dbContext.SaveChanges();
                    entity.Id = model.Id;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(RepuestoEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Repuesto.Find(entity.Id);
                    if (model == null) throw new Exception("El repuesto no existe.");

                    model.Codigo = entity.Codigo;
                    model.Descripcion = entity.Descripcion;
                    model.Precio = entity.Precio;
                    model.StockFisico = entity.StockFisico;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void delete(int id)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Repuesto.Find(id);
                    if (model == null) throw new Exception("El repuesto no existe.");

                    dbContext.Remove(model);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

