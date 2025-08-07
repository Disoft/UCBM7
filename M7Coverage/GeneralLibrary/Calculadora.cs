namespace GeneralLibrary
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }

        public string EvaluarNumero(int numero)
        {
            if (numero > 0)
            {
                return "Positivo";
            }
            else
            {
                return "No positivo";
            }
        }

        public int Calcular(int a, int b)
        {
            int resultado = 0; // def(resultado)

            if (a > 0 && b > 0)
            {
                resultado = a + b; // def(resultado)
            }

            return resultado; // use(resultado)
        }
    }
}
