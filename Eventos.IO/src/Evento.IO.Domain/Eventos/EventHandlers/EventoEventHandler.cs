using Evento.IO.Domain.Eventos.Events;
using Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.IO.Domain.Eventos.EventHandlers
{
    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoExcluidoEvent>
    {
        public void Handler(EventoRegistradoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handler(EventoAtualizadoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handler(EventoExcluidoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }
    }
}
