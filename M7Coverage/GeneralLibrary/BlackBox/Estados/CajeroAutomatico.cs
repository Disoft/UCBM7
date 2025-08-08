using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.BlackBox.Estados
{
    public enum EstadoATM
    {
        SinTarjeta,
        ConTarjeta,
        Autenticado
    }

    public class CajeroAutomatico
    {
        public EstadoATM Estado { get; private set; } = EstadoATM.SinTarjeta;

        public void InsertarTarjeta()
        {
            if (Estado == EstadoATM.SinTarjeta)
                Estado = EstadoATM.ConTarjeta;
        }

        public void IngresarPIN(string pin)
        {
            if (Estado == EstadoATM.ConTarjeta && pin == "1234")
                Estado = EstadoATM.Autenticado;
        }

        public void ExpulsarTarjeta()
        {
            if (Estado == EstadoATM.ConTarjeta || Estado == EstadoATM.Autenticado)
                Estado = EstadoATM.SinTarjeta;
        }
    }
}
