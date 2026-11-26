using System;
using System.Collections.Generic;

namespace Entities
{
    public class DetalleOrdenEntity
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdRepuesto { get; set; }
        public string DescripcionRepuesto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

    public class OrdenTrabajoEntity
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public decimal CostoTotal { get; set; }
        public int? IdTecnico { get; set; }

        public int IdVehiculo { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public DateTime? FechaCierre { get; set; }
        public int KilometrajeIngreso { get; set; }
        public string Diagnostico { get; set; }
        public decimal ManoObra { get; set; }
        public decimal Impuestos { get; set; }
        public List<DetalleOrdenEntity> Detalles { get; set; } = new List<DetalleOrdenEntity>();
    }
}