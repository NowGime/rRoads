using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Resume
{
    public int Id { get; set; }

    public DateTime? DateFile { get; set; }

    public int? DirectionId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Direction? Direction { get; set; }
}
