using DAL.Models;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    return dbContext.Repuesto
                        .Select(m => RepuestoMapper.ToEntity(m))
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RepuestoEntity getByCodigo(string codigo)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Repuesto.FirstOrDefault(r => r.Codigo == codigo);
                    return RepuestoMapper.ToEntity(model);
                }
            }
            catch (Exception)
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
                    dbContext.Repuesto.Add(model);
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