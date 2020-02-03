using PatronEstrategia.Interfaces;

namespace PatronEstrategia.Factory.Interface
{
    public interface IFabricaImagen
    {
        IGuardarImagen CrearInstancia(int iTipoInstancia);
    }
}
