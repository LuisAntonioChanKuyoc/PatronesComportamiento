namespace PatronCadenaResponsabilidad
{
    public interface IHandler
    {
        IHandler NextLevel(IHandler handler);

        string Handle(int iImporte);
    }
}
