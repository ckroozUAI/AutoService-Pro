using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class ClienteModel
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<VehiculoModel> Vehiculos { get; set; } = new List<VehiculoModel>();
}
