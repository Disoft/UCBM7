namespace GeneralLibrary.BlackBox.Subprocesos
{
    public class ContadorSeguro
    {
        private int _contador = 0;
        private readonly object _lock = new object();

        public void Incrementar()
        {
            lock (_lock)
            {
                _contador++;
            }
        }

        public int ObtenerValor()
        {
            lock (_lock)
            {
                return _contador;
            }
        }
    }

    public class ContadorInseguro
    {
        private int _contador = 0;

        public void Incrementar()
        {
            _contador++;
        }

        public int ObtenerValor()
        {
            return _contador;
        }
    }
}