using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Models
{
    //clase base para ser somente herdada
    public abstract class Entity
    {
        //somente a própria classe pode setar o id
        public Guid Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }
    }
}
