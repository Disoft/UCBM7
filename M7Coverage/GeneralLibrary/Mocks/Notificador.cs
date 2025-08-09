using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Mocks
{
    public interface IEmailService
    {
        void EnviarCorreo(string destinatario, string mensaje);
    }

    public class Notificador
    {
        private readonly IEmailService _emailService;

        public Notificador(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void NotificarUsuario(string usuario)
        {
            _emailService.EnviarCorreo(usuario, "Tienes un nuevo mensaje");
        }
    }
}
