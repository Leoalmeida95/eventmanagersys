using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento.IO.Domain.Models.Evento("Nome", DateTime.Now, DateTime.Now, false, 50, false, "A");

            Console.WriteLine(evento.ToString());
            var name = Console.ReadLine();
        }
    }
}
