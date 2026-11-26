using Entities;
using Entities.Models;

namespace Mapper
{
    public class OrdenServicioMapper
    {
        public static OrdenServicioEntity ToEntity(OrdenServicioModel model)
        {
            if (model == null) return null;

            return new OrdenServicioEntity
            {
                IdOrden = model.IdOrden,
                IdVehiculo = model.IdVehiculo,
                IdTecnico = model.IdTecnico,
                FechaIngreso = model.FechaIngreso,
                FechaCierre = model.FechaCierre,
                Estado = model.Estado,
                ManoObra = model.ManoObra,
                TotalRepuestos = model.TotalRepuestos,
                Total = model.Total
            };
        }

        public static OrdenServicioModel ToModel(OrdenServicioEntity entity)
        {
            if (entity == null) return null;

            return new OrdenServicioModel
            {
                IdOrden = entity.IdOrden,
                IdVehiculo = entity.IdVehiculo,
                IdTecnico = entity.IdTecnico,
                FechaIngreso = entity.FechaIngreso,
                FechaCierre = entity.FechaCierre,
                Estado = entity.Estado,
                ManoObra = entity.ManoObra,
                TotalRepuestos = entity.TotalRepuestos,
                Total = entity.Total
            };
        }
    }
}