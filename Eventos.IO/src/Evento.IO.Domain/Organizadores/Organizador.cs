using Eventos.IO.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Organizadores
{
    public class Organizador : Entity<Organizador>
    {
        public Organizador(Guid id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

        //EF Constructor
        public Organizador()
        {
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public ICollection<Eventos.Evento> Eventos { get; set; }

        public override bool EhValido()
        {
            return true;
        }
    }
}