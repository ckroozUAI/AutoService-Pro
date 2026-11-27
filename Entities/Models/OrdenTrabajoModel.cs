using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OrdenTrabajoModel
    {
        public int IdOrden { get; set; }
        public int IdVehiculo { get; set; }
        public int? IdTecnico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Estado { get; set; } = null!;
        public decimal ManoObra { get; set; }
        public decimal TotalRepuestos { get; set; }
        public decimal Total { get; set; }
        public int Kilometraje { get; set; }
    }
}
