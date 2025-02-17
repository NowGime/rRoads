using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Area
{
    public int Id { get; set; }

    public virtual ICollection<Materioal> Materioals { get; set; } = new List<Materioal>();
}
