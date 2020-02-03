using PatronCadenaResponsabilidad.Handler;
using System;
using PatronCadenaResponsabilidad.Responsabilidades;

namespace PatronCadenaResponsabilidad
{
    public class Cliente
    {
        public void Main()
        {
            Iniciar();
        }

        private static void Iniciar()
        {
            Console.WriteLine("Ingresa el monto de la compra");
            int iImporte = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Concepto de la compra");
            string cConcepto = Console.ReadLine();

            var Director = new Director();
            var Subdirector = new Subdirector();
            var Gerente = new Gerente();
            var Coordinador = new Coordinador();

            Coordinador.NextLevel(Gerente).NextLevel(Subdirector).NextLevel(Director);
            Aprobador aprobador = new Aprobador();

            aprobador.ProcesarInformacion(Coordinador, iImporte, cConcepto);
            VolverIniciar();
        }

        private static void VolverIniciar()
        {
            Console.WriteLine("\n\nPara continuar presione cualquier tecla, para salir presione 0");
            string opt = Console.ReadLine();

            if (opt != "0")
            {
                Console.Clear();
                Iniciar();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
