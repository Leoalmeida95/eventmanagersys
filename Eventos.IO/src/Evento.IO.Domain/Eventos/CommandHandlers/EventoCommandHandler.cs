using Evento.IO.Domain.CommandHandlers;
using Evento.IO.Domain.Eventos.Commands;
using Evento.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.IO.Domain.Eventos.CommandsHandlers
{
    public class EventoCommandHandler : CommandHandler,
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<ExcluirEventoCommand>
    {
        private readonly IEventoRepository _eventoRepository;

        //Injeção de dependência
        public EventoCommandHandler(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public void Handler(RegistrarEventoCommand message)
        {
            var evento = new Evento(
                message.Nome,
                message.DataInicio,
                message.DataFim,
                message.Gratuito,
                message.Valor,
                message.Online,
                message.NomeEmpresa
                );

            if (!evento.EhValido())
            {
                NotificarValidacoesErro(evento.ValidationResult);
                return;
            }

            //Validações de negócio

            //Persistencia
            _eventoRepository.Add(evento);
        }

        public void Handler(AtualizarEventoCommand message)
        {
            throw new NotImplementedException();
        }

        public void Handler(ExcluirEventoCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
