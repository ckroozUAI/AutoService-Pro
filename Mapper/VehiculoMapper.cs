using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class VehiculoMapper
    {
        public static VehiculoEntity ToEntity(VehiculoModel model)
        {
            return new VehiculoEntity
            {
                Id = model.Id,
                IdCliente = model.IdCliente,
                Patente = model.Patente,
                Marca = model.Marca,
                Modelo = model.Modelo,
                Anio = model.Anio,
                Color = model.Color,
                FechaRegistro = model.FechaRegistro
            };
        }

        public static VehiculoModel ToModel(VehiculoEntity entity)
        {
            return new VehiculoModel
            {
                Id = entity.Id,
                IdCliente = entity.IdCliente,
                Patente = entity.Patente,
                Marca = entity.Marca,
                Modelo = entity.Modelo,
                Anio = entity.Anio,
                Color = entity.Color,
                FechaRegistro = entity.FechaRegistro
            };
        }
    }
}
