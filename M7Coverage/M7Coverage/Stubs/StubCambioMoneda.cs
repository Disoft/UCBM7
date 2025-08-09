using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Coverage.Stubs
{
    public interface IApiCambioMoneda
    {
        decimal ObtenerTipoCambio(string moneda);
    }

    public class StubCambioMoneda : IApiCambioMoneda
    {
        public decimal ObtenerTipoCambio(string moneda)
        {
            return 7.0m; // Tipo de cambio fijo para pruebas
        }
    }
}
