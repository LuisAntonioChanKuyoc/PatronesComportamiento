using PatronObservador.Interfaces;
using System;

namespace PatronObservador.Tareas
{
    public class Compilador : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Compilación de código correcta.");
        }
    }
}
