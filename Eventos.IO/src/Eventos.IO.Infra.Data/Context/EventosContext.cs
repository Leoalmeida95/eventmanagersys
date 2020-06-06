using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Evento.IO.Domain.Eventos;
using Evento.IO.Domain.Organizadores;
using System.IO;
using Microsoft.Extensions.Configuration;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.IO.Infra.Data.Context
{
    public class EventosContext : DbContext
    {
        public DbSet<Evento.IO.Domain.Eventos.Evento> Eventos { get; set; }
        public DbSet<Organizador> Organizadores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        [NotMapped]
        public DbSet<ValidationFailure> ValidationFailure { get; set; }

        [NotMapped]
        public DbSet<ValidationResult> ValidationResult { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentAPI

            #region Evento
            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                .Property(e => e.Nome)
                                .HasColumnType("varchar(150)")
                                .IsRequired();

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                .Property(e => e.DescricaoCurta)
                                .HasColumnType("varchar(150)");

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                .Property(e => e.DescricaoLonga)
                                .HasColumnType("varchar(max)");

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                .Property(e => e.NomeEmpresa)
                                .HasColumnType("varchar(150)")
                                .IsRequired();


            //ignora as colunas
            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .Ignore(e => e.ValidationResult);

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .Ignore(e => e.Tags);

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .Ignore(e => e.CascadeMode);

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .ToTable("Eventos");

            //relacionamentos
            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .HasOne(e => e.Organizador)
                                 .WithMany(o => o.Eventos)
                                 .HasForeignKey(a => a.OrganizadorId);

            modelBuilder.Entity<Evento.IO.Domain.Eventos.Evento>()
                                 .HasOne(e => e.Categoria)
                                 .WithMany(o => o.Eventos)
                                 .HasForeignKey(a => a.CategoriaId)
                                 .IsRequired(false);

            #endregion

            #region Endereco

            modelBuilder.Entity<Endereco>()
                                 .HasOne(a => a.Evento)
                                 .WithOne(b => b.Endereco)
                                 .HasForeignKey<Endereco>(c => c.EventoId)
                                 .IsRequired(false);

            modelBuilder.Entity<Endereco>()
                                 .Ignore(e => e.ValidationResult);

            modelBuilder.Entity<Endereco>()
                                 .Ignore(e => e.CascadeMode);

            modelBuilder.Entity<Endereco>()
                                 .ToTable("Enderecos");

            #endregion

            #region Organizador

            modelBuilder.Entity<Organizador>()
                                 .Ignore(e => e.ValidationResult);

            modelBuilder.Entity<Organizador>()
                                 .Ignore(e => e.CascadeMode);

            modelBuilder.Entity<Organizador>()
                                 .ToTable("Organizadores");

            #endregion

            #region Categoria

            modelBuilder.Entity<Categoria>()
                                 .Ignore(e => e.ValidationResult);

            modelBuilder.Entity<Categoria>()
                                 .Ignore(e => e.CascadeMode);

            modelBuilder.Entity<Categoria>()
                                 .ToTable("Categorias");

            #endregion

            #region ValidationResult
            modelBuilder.Ignore<ValidationFailure>();

            modelBuilder.Ignore<ValidationResult>();
            #endregion

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //definindo connection string
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
