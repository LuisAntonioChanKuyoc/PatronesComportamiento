using PatronCadenaResponsabilidad.Handler;

namespace PatronCadenaResponsabilidad.Responsabilidades
{
    public class Director : AbstractHandler
    {
        public override string Handle(int iImporte)
        {
            if (iImporte > 15000 && iImporte <= 50000)
            {
                return "AUTORIZADA por el Director";
            }
            else
            {
                return "DENEGADA";
            }
        }
    }
}
