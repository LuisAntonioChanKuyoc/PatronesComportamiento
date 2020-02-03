namespace PatronObservador.Interfaces
{
    public interface ITareasObservador
    {
        void AgregarObservador(IObservador observador);
        void EliminarObservador(IObservador observador);
        void Notificar();
        //void NotificarObservador(IObservador observador);
    }
}
