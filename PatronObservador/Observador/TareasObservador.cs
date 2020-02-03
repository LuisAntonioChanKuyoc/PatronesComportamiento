using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;

namespace PatronObservador.Tareas
{
    public class TareasObservador : ITareasObservador
    {
        readonly List<IObservador> lstObservadores = new List<IObservador>();

        public void AgregarObservador(IObservador observador)
        {
            lstObservadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            lstObservadores.Remove(observador);
        }

        public void Notificar()
        {
            Console.WriteLine("\nSe sube código");

            foreach (var observador in lstObservadores)
            {
                observador.Actualizar();
            }

            lstObservadores.Clear();
        }

        public void SubirCambios()
        {
            Notificar();
        }
    }
}
