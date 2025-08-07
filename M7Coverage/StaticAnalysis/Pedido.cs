using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAnalysis
{
    public class Pedido
    {
        public int Cantidad;
        public decimal PrecioUnitario;
        public decimal Total;

        public void CalcularTotal()
        {
            Total = Cantidad * PrecioUnitario;
        }

        public void Mostrar()
        {
            Console.WriteLine("Total: " + Total.ToString("C")); 
        }
    }
}
