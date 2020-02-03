using PatronObservador.Interfaces;
using System;

namespace PatronObservador.Tareas
{
    public class SubirCodigo : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Commit de código de la versión 1.1.");
        }
    }
}
