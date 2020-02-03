using PatronEstrategia.Interfaces;

namespace PatronEstrategia.Strategy
{
    public class JPGEStrategy : IGuardarImagen
    {
        public string Guardar(string cNombre)
        {
            return $"{cNombre}.JPGE";
        }
    }
}
