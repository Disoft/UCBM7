using GeneralLibrary.IntegrationTest;

namespace M7Coverage.IntegrationTests.Bussiness
{
    public class ValidadorBasico : IValidadorUsuario
    {
        public bool EsValido(UsuarioIntegration usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario.Nombre) &&
                   usuario.Email.Contains("@");
        }
    }
}