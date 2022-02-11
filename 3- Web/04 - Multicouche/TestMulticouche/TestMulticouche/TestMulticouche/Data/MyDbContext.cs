using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestMulticouche.Data.Models;

#nullable disable

namespace TestMulticouche.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Texte> Textes { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PRIMARY");

                entity.ToTable("articles");

                entity.Property(e => e.IdArticle)
                    .HasColumnType("int(11)")
                    .HasColumnName("idArticle");

                entity.Property(e => e.DescriptionArticle)
                    .HasMaxLength(50)
                    .HasColumnName("descriptionArticle");

                entity.Property(e => e.PrixArticle)
                    .HasColumnType("int(11)")
                    .HasColumnName("prixArticle");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PRIMARY");

                entity.ToTable("clients");

                entity.Property(e => e.IdClient)
                    .HasColumnType("int(11)")
                    .HasColumnName("idClient");

                entity.Property(e => e.DateEntreeClient)
                    .HasColumnType("date")
                    .HasColumnName("dateEntreeClient");

                entity.Property(e => e.NomClient)
                    .HasMaxLength(50)
                    .HasColumnName("nomClient");

                entity.Property(e => e.PrenomClient)
                    .HasMaxLength(50)
                    .HasColumnName("prenomClient");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commandes");

                entity.HasIndex(e => e.IdArticle, "fk_Commandes_Articles");

                entity.HasIndex(e => e.IdClient, "fk_Commandes_CLients");

                entity.Property(e => e.IdCommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCommande");

                entity.Property(e => e.CdeTotal)
                    .HasColumnType("int(11)")
                    .HasColumnName("cde_total");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("date")
                    .HasColumnName("dateCommande");

                entity.Property(e => e.IdArticle)
                    .HasColumnType("int(11)")
                    .HasColumnName("idArticle");

                entity.Property(e => e.IdClient)
                    .HasColumnType("int(11)")
                    .HasColumnName("idClient");

                entity.Property(e => e.QuantiteCommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantiteCommande");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("fk_Commandes_Articles");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("fk_Commandes_CLients");
            });

            modelBuilder.Entity<Texte>(entity =>
            {
                entity.HasKey(e => e.IdTexte)
                    .HasName("PRIMARY");

                entity.ToTable("textes");

                entity.Property(e => e.IdTexte)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTexte");

                entity.Property(e => e.CodeTexte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeTexte");

                entity.Property(e => e.En)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("en");

                entity.Property(e => e.Fr)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("fr");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur)
                    .HasName("PRIMARY");

                entity.ToTable("utilisateurs");

                entity.HasIndex(e => e.AdresseMail, "adresseMail")
                    .IsUnique();

                entity.Property(e => e.IdUtilisateur)
                    .HasColumnType("int(11)")
                    .HasColumnName("idUtilisateur");

                entity.Property(e => e.AdresseMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adresseMail");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("motDePasse");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prenom");

                entity.Property(e => e.Role)
                    .HasColumnType("int(11)")
                    .HasColumnName("role")
                    .HasComment("2 Admin 1 User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
