using Eventos.IO.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.IO.Domain.Eventos.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
