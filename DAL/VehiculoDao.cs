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
    public class VehiculoDao
    {
        public List<VehiculoEntity> getByCliente(int idCliente)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    return dbContext.Vehiculo.AsNoTracking()
                        .Where(v => v.IdCliente == idCliente)
                        .OrderBy(v => v.Patente)
                        .ToList()
                        .Select(VehiculoMapper.ToEntity)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public  VehiculoEntity getById(int id)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var v= dbContext.Vehiculo.FirstOrDefault(v => v.Id == id);
                    if(v!=null) return Mapper.VehiculoMapper.ToEntity(v);
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public bool hasVehiculos(int idCliente)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    return dbContext.Vehiculo.Any(v => v.IdCliente == idCliente);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public VehiculoEntity? getByPatente(string patente)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Vehiculo.AsNoTracking().FirstOrDefault(v => v.Patente == patente);
                    return model == null ? null : VehiculoMapper.ToEntity(model);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void create(VehiculoEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    entity.FechaRegistro = DateTime.Now;
                    var model = VehiculoMapper.ToModel(entity);
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

        public void update(VehiculoEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Vehiculo.Find(entity.Id);
                    if (model == null) throw new Exception("El vehículo no existe.");

                    model.Patente = entity.Patente;
                    model.Marca = entity.Marca;
                    model.Modelo = entity.Modelo;
                    model.Anio = entity.Anio;
                    model.Color = entity.Color;
                    model.Kilometraje = entity.Kilometraje;
                    dbContext.Update(model);
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
                    var model = dbContext.Vehiculo.Find(id);
                    if (model == null) throw new Exception("El vehículo no existe.");

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
