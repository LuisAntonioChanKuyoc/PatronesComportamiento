using System;

namespace PatronCadenaResponsabilidad.Handler
{
    public class Aprobador
    {
        public void ProcesarInformacion(AbstractHandler handler, int iImporte, string cConcepto)
        {
            string result = handler.Handle(iImporte);

            Console.WriteLine($"\n{cConcepto} \"{result}\"");
        }
    }
}
