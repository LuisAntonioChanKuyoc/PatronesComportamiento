using PatronObservador.Interfaces;
using System;

namespace PatronObservador.Tareas
{
    public class EnviarCorreo : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1.");
        }
    }
}
