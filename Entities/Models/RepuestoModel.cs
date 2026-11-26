using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RepuestoModel
    {
        public int Id { get; set; }

        public string Codigo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public decimal Precio { get; set; }

        public int StockFisico { get; set; }
    }
}
