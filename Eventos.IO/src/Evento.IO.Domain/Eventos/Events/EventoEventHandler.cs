﻿using Eventos.IO.Domain.Core.Events;
using System;

namespace Evento.IO.Domain.Eventos.Events
{
    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento Registrado com sucesso");
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento Atualizado com sucesso");
            //Enviar um e-mail
            //Fazer um log
        }

        public void Handle(EventoExcluidoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento Excluido com sucesso");
            //Enviar um e-mail
            //Fazer um log
        }
    }
}