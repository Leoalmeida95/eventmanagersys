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
using Eventos.IO.Infra.Data.Mappings;
using Eventos.IO.Infra.Data.Extensions;

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
            modelBuilder.Ignore<ValidationFailure>();
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.AddConfiguration(new EventoMapping());
            modelBuilder.AddConfiguration(new OrganizadorMapping());
            modelBuilder.AddConfiguration(new CategoriaMapping());
            modelBuilder.AddConfiguration(new EnderecoMapping());

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
