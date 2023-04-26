using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using backend_1.Models;

namespace backend_1.Data;

public partial class DbBurseContext : DbContext
{
    public DbBurseContext()
    {
    }

    public DbBurseContext(DbContextOptions<DbBurseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abonament> Abonaments { get; set; }

    public virtual DbSet<Bursa> Bursas { get; set; }

    public virtual DbSet<BursaDenumire> BursaDenumires { get; set; }

    public virtual DbSet<Facultate> Facultates { get; set; }

    public virtual DbSet<Specializare> Specializares { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TipAbonament> TipAbonaments { get; set; }

    public virtual DbSet<TipStudent> TipStudents { get; set; }

    public virtual DbSet<TipTara> TipTaras { get; set; }

    public virtual DbSet<ValoareBursa> ValoareBursas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=horatiusql;Database=db_burse;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abonament>(entity =>
        {
            entity.HasKey(e => e.CodAbo).HasName("PK__ABONAMEN__149C569FC67408FB");

            entity.Property(e => e.CodAbo).ValueGeneratedNever();

            entity.HasOne(d => d.CnpNavigation).WithMany(p => p.Abonaments).HasConstraintName("FK__ABONAMENT__CNP__4BAC3F29");
        });

        modelBuilder.Entity<Bursa>(entity =>
        {
            entity.HasOne(d => d.CnpNavigation).WithMany().HasConstraintName("FK__BURSE__CNP__4222D4EF");
        });

        modelBuilder.Entity<BursaDenumire>(entity =>
        {
            entity.HasKey(e => e.Denumire).HasName("PK__bursa_De__E8D6990AF61A03CE");
        });

        modelBuilder.Entity<Facultate>(entity =>
        {
            entity.HasKey(e => e.IdFacultate).HasName("PK__FACULTAT__DAEF0D2CDE6FCEB2");

            entity.Property(e => e.IdFacultate).ValueGeneratedNever();
        });

        modelBuilder.Entity<Specializare>(entity =>
        {
            entity.HasKey(e => e.IdSpecializare).HasName("PK__SPECIALI__744ECA9DF57DB377");

            entity.Property(e => e.IdSpecializare).ValueGeneratedNever();

            entity.HasOne(d => d.IdFacultateNavigation).WithMany(p => p.Specializares).HasConstraintName("FK__SPECIALIZ__ID_FA__33D4B598");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Cnp).HasName("PK__STUDENT__C1FF677CFF24635F");

            entity.HasOne(d => d.IdSpecializareNavigation).WithMany(p => p.Students).HasConstraintName("FK__STUDENT__ID_SPEC__3C69FB99");

            entity.HasOne(d => d.TipStudNavigation).WithMany(p => p.Students).HasConstraintName("FK__STUDENT__TIP_STU__3B75D760");

            entity.HasOne(d => d.TipTaraNavigation).WithMany(p => p.Students).HasConstraintName("FK__STUDENT__TIP_TAR__3A81B327");
        });

        modelBuilder.Entity<TipAbonament>(entity =>
        {
            entity.HasOne(d => d.CodAboNavigation).WithMany().HasConstraintName("FK__TIP_ABONA__COD_A__4D94879B");
        });

        modelBuilder.Entity<TipStudent>(entity =>
        {
            entity.HasKey(e => e.TipStud).HasName("PK__TIP_STUD__0D88919CCDD72C75");
        });

        modelBuilder.Entity<TipTara>(entity =>
        {
            entity.HasKey(e => e.TipTara1).HasName("PK__TIP_TARA__5A23655B5C74A97C");
        });

        modelBuilder.Entity<ValoareBursa>(entity =>
        {
            entity.HasOne(d => d.DenumireNavigation).WithMany().HasConstraintName("FK__valoare_b__denum__59FA5E80");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
