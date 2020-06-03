using Evento.IO.Domain.Eventos;
using Evento.IO.Domain.Eventos.Commands;
using Evento.IO.Domain.Eventos.Events;
using Evento.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new FakeBus();

            // registro com sucesso
            var date1 = DateTime.Now.AddDays(1);
            var date2 = DateTime.Now.AddDays(2);
            var cmd = new RegistrarEventoCommand("DevX", date1, date2, true, 0, true, "Empresa");
            Inicio(cmd);
            bus.SendCommand(cmd);
            Fim(cmd);

            cmd = new RegistrarEventoCommand("", DateTime.Now.AddDays(2), DateTime.Now.AddDays(1), false, 0, false, "");
            Inicio(cmd);
            bus.SendCommand(cmd);
            Fim(cmd);

            var cmd2 = new AtualizarEventoCommand(Guid.NewGuid(), "DevX", "", "", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), false, 50, true, "Empresa");
            Inicio(cmd2);
            bus.SendCommand(cmd2);
            Fim(cmd2);

            var cmd3 = new ExcluirEventoCommand(Guid.NewGuid());
            Inicio(cmd3);
            bus.SendCommand(cmd3);
            Fim(cmd3);

            Console.ReadKey();
        }

        private static void Inicio(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Inicio do Commando " + message.MessageType);
        }

        private static void Fim(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Fim do Commando " + message.MessageType);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************");
            Console.WriteLine("");
        }

        private class FakeBus : IBus
        {
            public FakeBus()
            {
            }

            public void RaiseEvent<T>(T theEvent) where T : Event
            {
                Publish(theEvent);
            }

            public void SendCommand<T>(T theCommand) where T : Command
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Comando {theCommand.MessageType} Lançado");
                Publish(theCommand);
            }

            private static void Publish<T>(T message) where T : Message
            {
                var msgType = message.MessageType;

                if (msgType.Equals("DomainNotification"))
                {
                    var obj = new DomainNotificationHandler();
                    ((IDomainNotificationHandler<T>)obj).Handle(message);
                }

                if (msgType.Equals("RegistrarEventoCommand") ||
                    msgType.Equals("AtualizarEventoCommand") ||
                    msgType.Equals("ExcluirEventoCommand"))
                {
                    var obj = new EventoCommandHandler(new FakeRepository(),
                                                        new FakeUow(),
                                                        new FakeBus(),
                                                        new DomainNotificationHandler());
                    ((IHandler<T>)obj).Handle(message);
                }

                if (msgType.Equals("EventoRegistradoEvent") ||
                    msgType.Equals("EventoAtualizadoEvent") ||
                    msgType.Equals("EventoExcluidoEvent"))
                {
                    var obj = new EventoEventHandler();
                    ((IHandler<T>)obj).Handle(message);
                }
            }
        }
    }
}

public class FakeRepository : IEventoRepository
{
    public void AdicioanrEndereco(Endereco endereco)
    {
       //
    }

    public void Adicionar(Evento.IO.Domain.Eventos.Evento obj)
    {
       //
    }

    public void Atualizar(Evento.IO.Domain.Eventos.Evento obj)
    {
        //
    }

    public void AtualizarEndereco(Endereco endereco)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Evento.IO.Domain.Eventos.Evento> Buscar(Expression<Func<Evento.IO.Domain.Eventos.Evento, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Endereco ObterEnderecoPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Evento.IO.Domain.Eventos.Evento> ObterEventoPorOrganizador(Guid organizadorId)
    {
        throw new NotImplementedException();
    }

    public Evento.IO.Domain.Eventos.Evento ObterPorId(Guid id)
    {
        return new Evento.IO.Domain.Eventos.Evento("Fake", DateTime.Now, DateTime.Now, true, 0, true, "Empresa");
    }

    public IEnumerable<Evento.IO.Domain.Eventos.Evento> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public void Remover(Guid id)
    {
        //
    }

    public int SaveChanges()
    {
        throw new NotImplementedException();
    }
}

public class FakeUow : IUnitOfWork
{
    public CommandResponse Commit()
    {
        return new CommandResponse(true);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}