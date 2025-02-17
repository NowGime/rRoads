using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Type
{
    public int Id { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
