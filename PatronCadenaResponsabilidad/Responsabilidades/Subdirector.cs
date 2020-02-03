using PatronCadenaResponsabilidad.Handler;

namespace PatronCadenaResponsabilidad.Responsabilidades
{
    class Subdirector : AbstractHandler
    {
        public override string Handle(int iImporte)
        {
            if (iImporte > 10000 && iImporte <= 15000)
            {
                return "AUTORIZADA por el Subdirector";
            }
            else
            {
                return base.Handle(iImporte);
            }
        }
    }
}
