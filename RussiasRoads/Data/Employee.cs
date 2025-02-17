using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Employee
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string SurName { get; set; } = null!;

    public string? Photo { get; set; }

    public int SubdivisionId { get; set; }

    public int RoleId { get; set; }

    public int HeadId { get; set; }

    public int AssistanId { get; set; }

    public string Phone { get; set; } = null!;

    public int CabNum { get; set; }

    public string? Email { get; set; }

    public string? MobPhone { get; set; }

    public DateTime? BirthdayDate { get; set; }

    public string? Info { get; set; }

    public string? Code { get; set; }

    public virtual Employee Assistan { get; set; } = null!;

    public virtual Employee Head { get; set; } = null!;

    public virtual ICollection<Employee> InverseAssistan { get; set; } = new List<Employee>();

    public virtual ICollection<Employee> InverseHead { get; set; } = new List<Employee>();

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();

    public virtual ICollection<Miss> Misses { get; set; } = new List<Miss>();

    public virtual ICollection<News> News { get; set; } = new List<News>();

    public virtual ICollection<Responsible> Responsibles { get; set; } = new List<Responsible>();

    public virtual Role Role { get; set; } = null!;

    public virtual Subdivision Subdivision { get; set; } = null!;

    public virtual ICollection<Subdivision> Subdivisions { get; set; } = new List<Subdivision>();
}
