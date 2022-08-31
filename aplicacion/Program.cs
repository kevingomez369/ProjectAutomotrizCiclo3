using System;
using Dominio;

namespace aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona persona= new Persona();
            persona.Nombres="Wilson";
            persona.Apellidos="Alfonso";
            Console.WriteLine(persona.Nombres + " " + persona.Apellidos);
        }
    }
}
