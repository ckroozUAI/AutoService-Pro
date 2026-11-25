using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VehiculoEntity
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public string Patente { get; set; } = null!;

        public string Marca { get; set; } = null!;

        public string Modelo { get; set; } = null!;

        public int Anio { get; set; }

        public string? Color { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
