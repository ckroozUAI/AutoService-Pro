using System;

namespace Entities
{
    public class OrdenServicioEntity
    {
        public int IdOrden { get; set; }
        public int IdVehiculo { get; set; }
        public int? IdTecnico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Estado { get; set; } = "Presupuestada";
        public decimal ManoObra { get; set; }
        public decimal TotalRepuestos { get; set; }
        public decimal Total { get; set; }
        public int Kilometraje { get; set; }
    }
}