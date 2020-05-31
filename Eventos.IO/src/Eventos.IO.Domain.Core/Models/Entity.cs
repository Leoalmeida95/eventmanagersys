using FluentValidation;
using FluentValidation.Results;
using System;

namespace Eventos.IO.Domain.Core.Models
{
    //clase base para ser somente herdada
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
        //O AbstractValidator implementa uma classe generica T que herde de uma Entity
        //Caso Entity não implementasse uma classe genérica, o AbstractValidator valeria apenas para os campos de Entity
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        //somente a própria classe pode setar o id
        public Guid Id { get; protected set; }

        public abstract bool EhValido();

        public ValidationResult ValidationResult { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<T> a, Entity<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            //gera um hashcode único
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }
    }
}
