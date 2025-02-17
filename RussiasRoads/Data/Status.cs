using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Status
{
    public int Id { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Materioal> Materioals { get; set; } = new List<Materioal>();
}
