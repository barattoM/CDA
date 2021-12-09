using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Models;

namespace TestVoiture.Data
{
    public class MyDbContext:DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Voiture>(e2 =>
            //{
            //    e2.ToTable("Voitures");
            //    e2.Property(e => e.IdVoiture).HasColumnName("IdVoiture");
            //});

            modelBuilder.Entity<Personne>(e1 =>
            {
                e1.ToTable("Personnes");
                //e1.Property(e => e.IdVoiture).HasColumnName("IdVoiture");
                e1.HasOne(e => e.LaVoiture).WithOne().HasForeignKey<Voiture>(e => e.IdVoiture);
            });

            modelBuilder.Entity<Voiture>()
            .HasMany<Personne>(v => v.LesPersonnes)
            .WithOne(p => p.LaVoiture)
            .HasForeignKey(p => p.IdVoiture);
        }
    }
}
