using PatronEstrategia.Factory;
using PatronEstrategia.Factory.Interface;
using PatronEstrategia.Interfaces;
using System;

namespace PatronEstrategia
{
    public class Cliente
    {
        public void Main()
        {
            IFabricaImagen fabricaImagen = new FabricaImagen();

            do
            {
                Console.WriteLine("Ingresa el nombre de la imagen:  ");
                string cNombreImgagen = Console.ReadLine();

                IGuardarImagen TipoImagen = fabricaImagen.CrearInstancia(ObtenerTipoExtension());

                ImprimirImagen imprimir = new ImprimirImagen(TipoImagen);

                imprimir.Imprimir(cNombreImgagen);
            } while (true);
        }

        public int ObtenerTipoExtension()
        {
            Console.WriteLine("\nEliga el número que corresponda al formato en el que desea guardar la imagen" +
               "\n1. BMP" +
               "\n2. JPGE" +
               "\n3. PNG");

            var opt =Convert.ToInt32( Console.ReadLine());

            return opt;
        }
    }
}
