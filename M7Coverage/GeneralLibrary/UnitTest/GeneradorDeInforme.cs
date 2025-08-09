using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.UnitTest
{
    public class GeneradorDeInforme
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public GeneradorDeInforme(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public int ObtenerCantidadUsuarios()
        {
            var usuarios = _usuarioRepository.ObtenerUsuarios();
            return usuarios.Count;
        }
    }
}
