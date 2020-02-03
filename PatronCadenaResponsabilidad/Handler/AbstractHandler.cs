namespace PatronCadenaResponsabilidad.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual string Handle(int iImporte)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(iImporte);
            }
            else
            {
                return null;
            }
        }

        public IHandler NextLevel(IHandler handler)
        {
            _nextHandler = handler;

            return _nextHandler;
        }
    }
}
