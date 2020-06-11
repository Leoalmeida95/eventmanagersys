using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Infra.Data.Context;
using Eventos.IO.Domain.Eventos.Interfaces;

namespace Eventos.IO.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventosContext _context;

        public UnitOfWork(EventosContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
