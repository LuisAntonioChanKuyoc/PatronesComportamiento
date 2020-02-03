using PatronObservador.Interfaces;
using System;

namespace PatronObservador.Tareas
{
    public class Instalador : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Se ha instalado la versión 1.1.");
        }
    }
}
