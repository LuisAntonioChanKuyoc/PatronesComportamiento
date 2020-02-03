using PatronObservador.Tareas;
using System;

namespace PatronObservador
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new TareasObservador();

            Console.WriteLine("Tareas" +
           "\n 1.Subir el código." +
           "\n 2.Agregar Notificador." +
           "\n 3.Agregar Compilador." +
           "\n 4.Agregar Ejecutor de Pruebas Unitarias." +
           "\n 5.Agregar Instalador." +
           "\n 6.Salir.\n");

            int Tarea;

            do
            {
                Console.Write("Seleccione una opción: ");

                Tarea = Convert.ToInt32(Console.ReadLine());

                switch (Tarea)
                {
                    case 1:
                        var subirCodigo = new SubirCodigo();
                        subject.AgregarObservador(subirCodigo);
                        subject.SubirCambios();

                        break;
                    case 2:
                        var enviarCorreo = new EnviarCorreo();
                        subject.AgregarObservador(enviarCorreo);
                        break;
                    case 3:
                        var compilador = new Compilador();
                        subject.AgregarObservador(compilador);
                        break;
                    case 4:
                        var ejecutorPruebasU = new EjecutorPruebasU();
                        subject.AgregarObservador(ejecutorPruebasU);
                        break;
                    case 5:
                        var instalador = new Instalador();
                        subject.AgregarObservador(instalador);
                        break;
                }

            } while (Tarea != 6);

            Console.ReadKey();
        }
    }
}
