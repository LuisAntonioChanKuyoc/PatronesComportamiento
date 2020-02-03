using PatronObservador.Interfaces;
using System;

namespace PatronObservador.Tareas
{
    public class EjecutorPruebasU : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas.");
        }
    }
}
