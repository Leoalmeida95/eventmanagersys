using Evento.IO.Domain.CommandHandlers;
using Evento.IO.Domain.Eventos.Commands;
using Evento.IO.Domain.Eventos.Events;
using Evento.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications;
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
        private readonly IBus _bus;

        //Injeção de dependência
        public EventoCommandHandler(IEventoRepository eventoRepository,
                                    IUnitOfWork uow,
                                    IBus bus,
                                    IDomainNotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _eventoRepository = eventoRepository;
            _bus = bus;
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

            if (Commit())
            {
                Console.WriteLine("Evento registrado com sucesso");
                _bus.RaiseEvent(new EventoRegistradoEvent(evento.Id, evento.Nome, evento.DataInicio, evento.DataFim, evento.Gratuito, evento.Valor, evento.Online, evento.NomeEmpresa));
            }
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
