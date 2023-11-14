using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.DataBase;

public partial class HouseCatalogContext : DbContext
{
    public HouseCatalogContext()
    {
    }

    public HouseCatalogContext(DbContextOptions<HouseCatalogContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Orders> Orders { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HouseCatalog;Username=postgres;Password=rootroot");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Orders>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TelephoneNumber).HasColumnName("telephonenumber");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.HouseId).HasColumnName("houseid");
        });

        modelBuilder.Entity<House>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("house_pkey");

            entity.ToTable("house");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.Countrooms).HasColumnName("countrooms");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Imagepath).HasColumnName("imagepath");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Square).HasColumnName("square");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
