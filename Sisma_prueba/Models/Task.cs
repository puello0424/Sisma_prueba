using System;
using System.Collections.Generic;

namespace Sisma_prueba.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Tarea { get; set; } = null!;

    public string Completada { get; set; } = null!;
}
