using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.IntegrationTest
{
    public interface IUsuarioRepositoryIntegration
    {
        void Guardar(UsuarioIntegration usuario);

        List<UsuarioIntegration> ObtenerTodos();
    }
}
