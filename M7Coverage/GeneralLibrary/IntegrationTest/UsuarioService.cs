using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.IntegrationTest
{
    public class UsuarioService
    {
        private readonly IUsuarioRepositoryIntegration _repo;
        private readonly IValidadorUsuario _validador;

        public UsuarioService(IUsuarioRepositoryIntegration repo, IValidadorUsuario validador)
        {
            _repo = repo;
            _validador = validador;
        }

        public bool AgregarUsuario(UsuarioIntegration usuario)
        {
            if (!_validador.EsValido(usuario)) return false;
            _repo.Guardar(usuario);
            return true;
        }
    }
}
