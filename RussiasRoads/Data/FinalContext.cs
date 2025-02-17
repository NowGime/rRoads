using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace RussiasRoads.Data;

public partial class FinalContext : DbContext
{
    public FinalContext()
    {
    }

    public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Direction> Directions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Materioal> Materioals { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<Meterialtype> Meterialtypes { get; set; }

    public virtual DbSet<Miss> Misses { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Reason> Reasons { get; set; }

    public virtual DbSet<Responsible> Responsibles { get; set; }

    public virtual DbSet<Resume> Resumes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Subdivision> Subdivisions { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<Workingcalendar> Workingcalendars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;database=final;uid=root;pwd=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("area");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Direction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("direction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.SubdivisionId, "a5_idx");

            entity.HasIndex(e => e.RoleId, "a6_idx");

            entity.HasIndex(e => e.HeadId, "a7_idx");

            entity.HasIndex(e => e.AssistanId, "a8_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthdayDate).HasColumnType("datetime");
            entity.Property(e => e.Code).HasMaxLength(45);
            entity.Property(e => e.Email).HasMaxLength(45);
            entity.Property(e => e.FirstName).HasMaxLength(45);
            entity.Property(e => e.Info).HasMaxLength(45);
            entity.Property(e => e.LastName).HasMaxLength(45);
            entity.Property(e => e.MobPhone).HasMaxLength(45);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Photo).HasMaxLength(45);
            entity.Property(e => e.SurName).HasMaxLength(45);

            entity.HasOne(d => d.Assistan).WithMany(p => p.InverseAssistan)
                .HasForeignKey(d => d.AssistanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("a8");

            entity.HasOne(d => d.Head).WithMany(p => p.InverseHead)
                .HasForeignKey(d => d.HeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("a7");

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("a6");

            entity.HasOne(d => d.Subdivision).WithMany(p => p.Employees)
                .HasForeignKey(d => d.SubdivisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("a5");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("event");

            entity.HasIndex(e => e.StatusId, "a11_idx");

            entity.HasIndex(e => e.TypeId, "a9_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");

            entity.HasOne(d => d.Status).WithMany(p => p.Events)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("a11");

            entity.HasOne(d => d.Type).WithMany(p => p.Events)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("a9");
        });

        modelBuilder.Entity<Materioal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("materioal");

            entity.HasIndex(e => e.EventId, "a13_idx");

            entity.HasIndex(e => e.StatusId, "a14_idx");

            entity.HasIndex(e => e.AreaId, "a15_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author).HasMaxLength(45);
            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");

            entity.HasOne(d => d.Area).WithMany(p => p.Materioals)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("a15");

            entity.HasOne(d => d.Event).WithMany(p => p.Materioals)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("a13");

            entity.HasOne(d => d.Status).WithMany(p => p.Materioals)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("a14");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meeting");

            entity.HasIndex(e => e.EmployeId, "a_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Employe).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.EmployeId)
                .HasConstraintName("a");
        });

        modelBuilder.Entity<Meterialtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meterialtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Miss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("miss");

            entity.HasIndex(e => e.EmployeeId, "a1_idx");

            entity.HasIndex(e => e.ReasonId, "b2_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.Misses)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("a1");

            entity.HasOne(d => d.Reason).WithMany(p => p.Misses)
                .HasForeignKey(d => d.ReasonId)
                .HasConstraintName("b1");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("news");

            entity.HasIndex(e => e.EmployeeId, "a2_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Text)
                .HasMaxLength(45)
                .HasColumnName("text");

            entity.HasOne(d => d.Employee).WithMany(p => p.News)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("a2");
        });

        modelBuilder.Entity<Reason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reason");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Responsible>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("responsible");

            entity.HasIndex(e => e.EventId, "a3_idx");

            entity.HasIndex(e => e.EmployId, "b_idx");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Employ).WithMany(p => p.Responsibles)
                .HasForeignKey(d => d.EmployId)
                .HasConstraintName("b");

            entity.HasOne(d => d.Event).WithMany(p => p.Responsibles)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("a3");
        });

        modelBuilder.Entity<Resume>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("resume");

            entity.HasIndex(e => e.DirectionId, "a4_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateFile).HasColumnType("datetime");

            entity.HasOne(d => d.Direction).WithMany(p => p.Resumes)
                .HasForeignKey(d => d.DirectionId)
                .HasConstraintName("a4");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Subdivision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("subdivisions");

            entity.HasIndex(e => e.MainEmployeeId, "a5_idx");

            entity.HasIndex(e => e.HeadId, "b_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Info)
                .HasMaxLength(45)
                .HasColumnName("info");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");

            entity.HasOne(d => d.Head).WithMany(p => p.InverseHead)
                .HasForeignKey(d => d.HeadId)
                .HasConstraintName("b3");

            entity.HasOne(d => d.MainEmployee).WithMany(p => p.Subdivisions)
                .HasForeignKey(d => d.MainEmployeeId)
                .HasConstraintName("a10");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("type");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Workingcalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("workingcalendar", tb => tb.HasComment("Список дней исключений в производственном календаре"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Идентификатор строки");
            entity.Property(e => e.ExceptionDate).HasComment("День-исключение");
            entity.Property(e => e.IsWorkingDay).HasComment("0 - будний день, но законодательно принят выходным; 1 - сб или вс, но является рабочим");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
