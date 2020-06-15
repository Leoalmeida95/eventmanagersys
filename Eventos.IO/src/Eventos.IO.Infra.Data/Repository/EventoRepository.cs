using Dapper;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventos.IO.Infra.Data.Repository
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        public EventoRepository(EventosContext context) : base(context)
        {

        }

        //O Dapper é adicionado pra além de melhorar a performance, resolver o problema de tracking do .net core
        public override IEnumerable<Evento> ObterTodos()
        {
            var Sql = @"SELECT
                            *
                        FROM
                            EVENTOS E
                        WHERE 
                            E.EXCLUIDO = 0
                        ORDER BY
                            E.DATAFIM DESC";

            return Db.Database.GetDbConnection().Query<Evento>(Sql);
        }

        public void AdicioanrEndereco(Endereco endereco)
        {
            Db.Enderecos.Add(endereco);
        }

        public void AtualizarEndereco(Endereco endereco)
        {
            Db.Enderecos.Update(endereco);
        }

        public Endereco ObterEnderecoPorId(Guid id)
        {
            var Sql = @"SELECT
                            *
                        FROM
                            ENDERECO E
                        WHERE 
                            E.ID = @uid";

            return Db.Database.GetDbConnection().Query<Endereco>(Sql, new { uid = id }).FirstOrDefault();
        }

        public IEnumerable<Evento> ObterEventosPorOrganizador(Guid organizadorId)
        {
            var Sql = @"SELECT
                            *
                        FROM
                            EVENTOS E
                        WHERE 
                            E.EXCLUIDO = 0
                            AND E.ORGANIZADORID = @oid
                        ORDER BY
                            E.DATAFIM DESC";

            return Db.Database.GetDbConnection().Query<Evento>(Sql, new { oid = organizadorId });
        }

        public override Evento ObterPorId(Guid id)
        {
            var Sql = @"SELECT
                            *
                        FROM
                            EVENTOS E
                            LEFT JOIN ENDERECOS EN ON E.ID = EN.EVENTOID
                        WHERE 
                            E.ID = @uid";

            //Os dois primeiros objetos são os que vem na consulta e o último é o objeto onde o resultado é armazenado
            return Db.Database.GetDbConnection().Query<Evento, Endereco, Evento>(Sql, 
                                                                                (e,en)=> {
                                                                                    if (en != null)
                                                                                        e.AtribuirEndereco(en);

                                                                                    return e;
                                                                                }, new {uid = id }).FirstOrDefault();
        }

        public override void Remover(Guid id)
        {
            var evento = ObterPorId(id);
            evento.ExcluirEvento();
            Atualizar(evento);
        }
    }
}
