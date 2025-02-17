using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Direction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Resume> Resumes { get; set; } = new List<Resume>();
}
