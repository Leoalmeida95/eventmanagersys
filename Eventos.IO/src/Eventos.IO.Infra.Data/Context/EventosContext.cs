using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Infra.Data.Context
{
    public class EventosContext : DbContext
    {
        public DbSet<Evento.IO.Domain.Eventos.Evento> Eventos { get; set; }
        public DbSet<Evento.IO.Domain.Organizadores.Organizador> Organizadores { get; set; }
        public DbSet<Evento.IO.Domain.Eventos.Categoria> Categorias { get; set; }
        public DbSet<Evento.IO.Domain.Eventos.Endereco> Enderecos { get; set; }
    }
}
