using Eventos.IO.Domain.Core.Commands;
using System;

namespace Eventos.IO.Domain.Eventos.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
