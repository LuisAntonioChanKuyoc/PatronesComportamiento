using PatronEstrategia.Interfaces;

namespace PatronEstrategia.Strategy
{
    public class PNGStrategy : IGuardarImagen
    {
        public string Guardar(string cNombre)
        {
            return $"{cNombre}.PNG";
        }
    }
}
