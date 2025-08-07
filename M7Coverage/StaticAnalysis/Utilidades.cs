using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAnalysis
{
    public class Utilidades
    {
        public int CalcularIVA(int monto)
        {
            return (int)(monto * 0.18);
        }

        public void CodigoMuerto()
        {
            int x = 5;
            return;
            Console.WriteLine(x); 
        }
    }
}
