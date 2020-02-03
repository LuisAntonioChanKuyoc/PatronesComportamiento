using PatronCadenaResponsabilidad.Handler;

namespace PatronCadenaResponsabilidad.Responsabilidades
{
    public class Coordinador:AbstractHandler
    {
        public override string Handle(int iImporte)
        {
            if (iImporte > 0 && iImporte <= 5000)
            {
                return "AUTORIZADA por el Coordinador";
            }
            else
            {
                return base.Handle(iImporte);
            }
        }
    }
}
