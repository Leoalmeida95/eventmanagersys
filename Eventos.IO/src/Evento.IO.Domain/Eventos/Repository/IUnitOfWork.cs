using Eventos.IO.Domain.Core.Commands;
using System;

namespace Evento.IO.Domain.Eventos.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
