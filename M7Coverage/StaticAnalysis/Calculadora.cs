using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAnalysis
{
    public class Calculadora
    {
        public double Dividir(int a, int b)
        {
            return a / b; 
        }

        public int Sumar(int a, int b, int c)
        {
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                        return a + b + c;
                }
            }
            return 0; 
        }
    }
}
