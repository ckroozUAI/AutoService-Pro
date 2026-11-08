using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class UsuarioMapper
    {
        public static UsuarioEntity ToEntity(UsuarioModel model)
        {
            if (model == null) return null;

            return new UsuarioEntity
            {
                Usuario = model.Usuario,
                Password = model.Password,
                FechaRegistro = model.FechaRegistro
            };
        }

        public static UsuarioModel ToModel(UsuarioEntity entity)
        {
            if (entity == null) return null;

            return new UsuarioModel
            {
                Id = entity.Id,
                Usuario = entity.Usuario,
                Password = entity.Password,
                FechaRegistro = entity.FechaRegistro
            };
        }
    }
}
