using Evento.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Evento.IO.Domain.Eventos.Repository
{
    public interface IEventoRepository : IRepository<Evento>
    {
        IEnumerable<Evento> ObterEventosPorOrganizador(Guid organizadorId);
        Endereco ObterEnderecoPorId(Guid id);
        void AdicioanrEndereco(Endereco endereco);
        void AtualizarEndereco(Endereco endereco);
    }
}
