using System;
using System.Collections.Generic;

namespace Sisma_prueba.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Tarea { get; set; } = null!;

    public bool Completada { get; set; } = false!;

   // public string Descripcion { get; set; } = null!;
}
