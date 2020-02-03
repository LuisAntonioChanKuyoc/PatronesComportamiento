using PatronEstrategia.Factory.Interface;
using PatronEstrategia.Interfaces;
using PatronEstrategia.Strategy;

namespace PatronEstrategia.Factory
{
    public class FabricaImagen : IFabricaImagen
    {
        public IGuardarImagen CrearInstancia(int iTipoInstancia)
        {
            IGuardarImagen imagen = null;
            switch (iTipoInstancia)
            {
                case 1:
                    imagen = new BMPStrategy();
                    break;
                case 2:
                    imagen = new JPGEStrategy();
                    break;
                case 3:
                    imagen = new PNGStrategy();
                    break;
            }

            return imagen;
        }
    }
}
