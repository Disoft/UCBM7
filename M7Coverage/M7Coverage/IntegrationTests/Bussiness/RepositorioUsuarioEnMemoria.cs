using GeneralLibrary.IntegrationTest;

namespace M7Coverage.IntegrationTests.Bussiness
{
    public class RepositorioUsuarioEnMemoria : IUsuarioRepositoryIntegration
    {
        private readonly List<UsuarioIntegration> _usuarios = new();

        public void Guardar(UsuarioIntegration usuario)
        {
            _usuarios.Add(usuario);
        }

        public List<UsuarioIntegration> ObtenerTodos()
        {
            return _usuarios;
        }
    }
}