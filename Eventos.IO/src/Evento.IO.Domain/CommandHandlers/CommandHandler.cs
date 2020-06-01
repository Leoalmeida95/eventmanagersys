using Evento.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Notifications;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.IO.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        public CommandHandler(IUnitOfWork uow, 
                              IBus bus,
                              IDomainNotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(error.PropertyName, error.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success) return true;

            Console.WriteLine("Erro ao salvar");
            _bus.RaiseEvent(new DomainNotification("Commit", "Erro ao salvar"));
            return false;
        }
    }
}
