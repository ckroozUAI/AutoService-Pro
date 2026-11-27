using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VehiculoModel
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string Patente { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Anio { get; set; }

    public string? Color { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ClienteModel Cliente { get; set; } = null!;
    public int Kilometraje { get; set; }
}
