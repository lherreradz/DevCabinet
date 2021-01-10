using System;

namespace TestDotNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensaje mensaje = new Mensaje { saludo = "Hola" };
            var user = new User("Alejo");
            Console.WriteLine($"{mensaje.saludo} {user.Name}");
        }

        private record User(string Name);

        private class Mensaje
        {
            public string saludo { get; set; }
        }
    }
}
