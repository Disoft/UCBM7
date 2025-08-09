using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.UnitTest
{
    public class GestorDePedidos
    {
        private readonly IInventarioService _inventarioService;
        private readonly IEmailService _emailService;

        public GestorDePedidos(IInventarioService inventarioService, IEmailService emailService)
        {
            _inventarioService = inventarioService;
            _emailService = emailService;
        }

        public bool ProcesarPedido(string productoId, string emailCliente)
        {
            if (_inventarioService.HayStock(productoId))
            {
                _emailService.EnviarCorreo(emailCliente, $"Su pedido del producto {productoId} fue procesado.");
                return true;
            }

            return false;
        }
    }
}
