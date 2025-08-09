using GeneralLibrary.IntegrationTest;
using M7Coverage.IntegrationTests.Bussiness;

namespace M7Coverage;

[TestClass]
public class UsuarioServiceIntegration
{
    [TestMethod]
    public void AgregarUsuario_Valido_DeberiaGuardar()
    {
        // Arrange
        var repo = new RepositorioUsuarioEnMemoria();
        var validador = new ValidadorBasico();
        var service = new UsuarioService(repo, validador);

        var usuario = new UsuarioIntegration
        {
            Nombre = "Ana",
            Email = "ana@mail.com"
        };

        // Act
        var resultado = service.AgregarUsuario(usuario);

        // Assert
        Assert.IsTrue(resultado);
        Assert.AreEqual(1, repo.ObtenerTodos().Count);
    }

    [TestMethod]
    public void AgregarUsuario_Invalido_NoDebeGuardar()
    {
        var repo = new RepositorioUsuarioEnMemoria();
        var validador = new ValidadorBasico();
        var service = new UsuarioService(repo, validador);

        var usuario = new UsuarioIntegration
        {
            Nombre = "",
            Email = "correo-invalido"
        };

        var resultado = service.AgregarUsuario(usuario);

        Assert.IsFalse(resultado);
        Assert.AreEqual(0, repo.ObtenerTodos().Count);
    }
}
