using Entities;
using Entities.Models;

namespace Mapper
{
    public class RepuestoMapper
    {
        public static RepuestoEntity ToEntity(RepuestoModel model)
        {
            if (model == null) return null;

            return new RepuestoEntity
            {
                IdRepuesto = model.IdRepuesto,
                Codigo = model.Codigo,
                Descripcion = model.Descripcion,
                Precio = model.Precio,
                StockFisico = model.StockFisico
            };
        }

        public static RepuestoModel ToModel(RepuestoEntity entity)
        {
            if (entity == null) return null;

            return new RepuestoModel
            {
                IdRepuesto = entity.IdRepuesto,
                Codigo = entity.Codigo,
                Descripcion = entity.Descripcion,
                Precio = entity.Precio,
                StockFisico = entity.StockFisico
            };
        }
    }
}