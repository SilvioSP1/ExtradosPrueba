using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }
}
