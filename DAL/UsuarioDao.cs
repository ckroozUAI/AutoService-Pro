using DAL.Models;
using Entities;
using Entities.Models;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDao
    {
        public void create(UsuarioEntity entity)
        {
            try
            {
                using (var dbContext= new AutoServiceContext())
                {
                    entity.FechaRegistro=DateTime.Now;
                    var model= UsuarioMapper.ToModel(entity);
                    dbContext.Add(model);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void login(UsuarioEntity entity)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {

                    var model =dbContext.Usuario.FirstOrDefault(u => u.Usuario.Equals(entity.Usuario) && u.Password.Equals(entity.Password));
                    if (model == null) throw new Exception("No se pudo realizar el inicio de sesión, verifique credenciales .");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioEntity getUser(string user)
        {
            try
            {
                using (var dbContext = new AutoServiceContext())
                {

                    var model = dbContext.Usuario.FirstOrDefault(u => u.Usuario.Equals(user));
                    if (model == null) throw new Exception("No se pudo realizar el inicio de sesión, verifique credenciales .");
                    return UsuarioMapper.ToEntity(model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
