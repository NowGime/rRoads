using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? TypeId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Materioal> Materioals { get; set; } = new List<Materioal>();

    public virtual ICollection<Responsible> Responsibles { get; set; } = new List<Responsible>();

    public virtual Status? Status { get; set; }

    public virtual Type? Type { get; set; }
}
