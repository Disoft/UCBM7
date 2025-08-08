using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.BlackBox.Riesgos
{
    public class CuentaBancaria
    {
        public decimal Saldo { get; private set; }
        public bool EstaAutenticado { get; set; }

        public CuentaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public bool Transferir(decimal monto)
        {
            if (!EstaAutenticado)
                throw new UnauthorizedAccessException("Usuario no autenticado.");

            if (monto > 10000)
                throw new InvalidOperationException("Transferencia excede el límite permitido.");

            if (Saldo - monto < 0)
                throw new InvalidOperationException("Fondos insuficientes.");

            Saldo -= monto;
            return true;
        }
    }
}
