using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UsuarioModel
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }
}
