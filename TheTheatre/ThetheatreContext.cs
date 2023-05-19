using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using TheTheatre.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TheTheatre;

public partial class TheTheatreContext : DbContext
{
    public TheTheatreContext()
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<TheatreWorker> TheatreWorkers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var dbPath = Path.Combine(appDataPath, "TheTheatre", "theTheatre.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TheatreWorker>().HasKey(u => u.TheatreWorkerId);
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


        Position _director = new Position { PositionId = 1, PosName = "Режиссер-постановщик" };
        Position _actor = new Position { PositionId = 2, PosName = "Актер" };
        Position _soundman = new Position { PositionId = 3, PosName = "Звукорежиссер" };
        Position _artist = new Position { PositionId = 4, PosName = "Художник" };
        modelBuilder.Entity<Position>().HasData(_artist, _soundman, _actor, _director);


    }
}