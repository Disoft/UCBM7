namespace GeneralLibrary
{
    public class Verificador
    {
        public string ClasificarNumero(int n)
        {
            if (n > 0)
            {
                if (n % 2 == 0)
                    return "Positivo par";
                else
                    return "Positivo impar";
            }
            else if (n < 0)
            {
                return "Negativo";
            }
            else
            {
                return "Cero";
            }
        }
    }
}
