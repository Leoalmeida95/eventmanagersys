using Eventos.IO.Domain.Core.Events;
using System;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoExcluidoEvent>,
        IHandler<EnderecoEventoAdicionadoEvent>,
        IHandler<EnderecoEventoAtualizadoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EventoExcluidoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EnderecoEventoAdicionadoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EnderecoEventoAtualizadoEvent message)
        {
            //Enviar um e-mail
            //Fazer um log
        }
    }
}
