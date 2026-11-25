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
    public class ClienteDao
    {
        public List<ClienteEntity> getAll()
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    return dbContext.Cliente.AsNoTracking()
                        .OrderBy(c => c.Apellido).ThenBy(c => c.Nombre)
                        .ToList()
                        .Select(ClienteMapper.ToEntity)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ClienteEntity? getByDni(string dni)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Cliente.AsNoTracking().FirstOrDefault(c => c.Dni == dni);
                    return model == null ? null : ClienteMapper.ToEntity(model);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void create(ClienteEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    entity.FechaRegistro = DateTime.Now;
                    var model = ClienteMapper.ToModel(entity);
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

        public void update(ClienteEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {
                    var model = dbContext.Cliente.Find(entity.Id);
                    if (model == null) throw new Exception("El cliente no existe.");

                    model.Nombre = entity.Nombre;
                    model.Apellido = entity.Apellido;
                    model.Dni = entity.Dni;
                    model.Telefono = entity.Telefono;
                    model.Email = entity.Email;
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
                    var model = dbContext.Cliente.Find(id);
                    if (model == null) throw new Exception("El cliente no existe.");

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
