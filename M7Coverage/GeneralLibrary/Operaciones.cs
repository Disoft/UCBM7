namespace GeneralLibrary
{
    public class Operaciones
    {
        public int CalcularResultado(bool multiplicar)
        {
            int x = 0;
            int resultado;

            if (multiplicar)
            {
                x = 5;
            }

            resultado = x + 2;

            return resultado;
        }
    }
}
