using PatronEstrategia.Interfaces;
using System;

namespace PatronEstrategia
{
    public class ImprimirImagen
    {
        private readonly IGuardarImagen _imagen;

        public ImprimirImagen(IGuardarImagen imagen)
        {
            _imagen = imagen;
        }

        public void Imprimir(string cNombre)
        {
            string mensaje = _imagen.Guardar(cNombre);

            Console.WriteLine($"Se ha guardado la imagen {mensaje}\n");
        }
    }
}
