using Eventos.IO.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }
        public virtual ICollection<Evento> Eventos { get; set; }

        //EF propriedade de navegação
        public virtual Evento Evento { get; private set; }

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