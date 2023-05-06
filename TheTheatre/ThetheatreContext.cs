using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TheTheatre;

public partial class ThetheatreContext : DbContext
{
    public ThetheatreContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<TheatreWorker> Theatreworkers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=theTheatre.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Show>()
            .HasMany(c => c.TheatreWorkers)
            .WithMany(s => s.Shows)
            .UsingEntity<Role>(
               j => j
                .HasOne(pt => pt.TheatreWorker)
                .WithMany(t => t.Roles)
                .HasForeignKey(pt => pt.TheatreWorkerId),
            j => j
                .HasOne(pt => pt.Show)
                .WithMany(p => p.Roles)
                .HasForeignKey(pt => pt.ShowName),
            j =>
            {
                j.Property(pt => pt.RoleName);
                j.HasKey(t => new { t.TheatreWorkerId, t.ShowName });
                j.ToTable("Roles");
            });

        Position _artist = new Position { PositionId = 4, PosName = "Художник" };
        Position _soundman = new Position { PositionId = 3, PosName = "Звукорежиссер" };
        Position _actor = new Position { PositionId = 2, PosName = "Актер" };
        Position _director = new Position { PositionId = 1, PosName = "Режиссер-постановщик" };
        modelBuilder.Entity<Position>().HasData(_artist, _soundman, _actor, _director);
    }
}


//d:\Users\admin\Desktop\theTheatre\TheTheatre\bin\Debug\net6.0-windows