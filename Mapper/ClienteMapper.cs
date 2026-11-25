using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ClienteMapper
    {
        public static ClienteEntity ToEntity(ClienteModel model)
        {
            return new ClienteEntity
            {
                Id = model.Id,
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Dni = model.Dni,
                Telefono = model.Telefono,
                Email = model.Email,
                FechaRegistro = model.FechaRegistro
            };
        }

        public static ClienteModel ToModel(ClienteEntity entity)
        {
            return new ClienteModel
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Dni = entity.Dni,
                Telefono = entity.Telefono,
                Email = entity.Email,
                FechaRegistro = entity.FechaRegistro
            };
        }
    }
}
