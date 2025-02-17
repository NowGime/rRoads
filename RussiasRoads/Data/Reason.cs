using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Reason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Miss> Misses { get; set; } = new List<Miss>();
}
