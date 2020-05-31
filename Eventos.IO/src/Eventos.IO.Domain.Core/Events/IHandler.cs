using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Events
{
    //Aceita qualquer classe que herde de Message
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}
