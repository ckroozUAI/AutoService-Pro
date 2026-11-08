using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsuarioEntity
    {
        public int Id { get; set; }

        public string Usuario { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? FechaRegistro { get; set; }
    }
}
