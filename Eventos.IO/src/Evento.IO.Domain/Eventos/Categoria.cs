using Eventos.IO.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }

        //EF propriedade de navegação
        public virtual ICollection<Evento> Eventos { get; private set; }

        public Categoria(Guid id)
        {
            Id = id;
        }

        // construtor EF
        protected Categoria()
        {

        }

        public override bool EhValido()
        {
            return true;
        }
    }
}