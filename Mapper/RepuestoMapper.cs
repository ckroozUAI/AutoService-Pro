using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class RepuestoMapper
    {
        public static RepuestoEntity ToEntity(RepuestoModel model)
        {
            return new RepuestoEntity
            {
                Id = model.Id,
                Codigo = model.Codigo,
                Descripcion = model.Descripcion,
                Precio = model.Precio,
                StockFisico = model.StockFisico
            };
        }

        public static RepuestoModel ToModel(RepuestoEntity entity)
        {
            return new RepuestoModel
            {
                Id = entity.Id,
                Codigo = entity.Codigo,
                Descripcion = entity.Descripcion,
                Precio = entity.Precio,
                StockFisico = entity.StockFisico
            };
        }
    }
}
