using PatronEstrategia.Interfaces;

namespace PatronEstrategia.Strategy
{
    public class BMPStrategy : IGuardarImagen
    {
        public string Guardar(string cNombre)
        {
            return $"{cNombre}.BPM";
        }
    }
}
