using PatronCadenaResponsabilidad.Handler;

namespace PatronCadenaResponsabilidad.Responsabilidades
{
    class Gerente : AbstractHandler
    {
        public override string Handle(int iImporte)
        {
            if (iImporte > 5000 && iImporte <= 10000)
            {
                return "AUTORIZADA por el Gerente";
            }
            else
            {
                return base.Handle(iImporte);
            }
        }
    }
}
