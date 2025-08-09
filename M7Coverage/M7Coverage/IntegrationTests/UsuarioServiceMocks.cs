using GeneralLibrary.IntegrationTest;
using Moq;

namespace M7Coverage;

[TestClass]
public class UsuarioServiceMocks
{
    [TestMethod]
    public void AgregarUsuario_Valido_DeberiaGuardar()
    {
        // Arrange
        var usuario = new UsuarioIntegration { Nombre = "Carlos", Email = "carlos@mail.com" };

        // Stub: siempre devuelve true al validar
        var stubValidador = new Mock<IValidadorUsuario>();
        stubValidador.Setup(v => v.EsValido(usuario)).Returns(true);

        // Mock: para verificar que Guardar fue llamado
        var mockRepo = new Mock<IUsuarioRepositoryIntegration>();

        var service = new UsuarioService(mockRepo.Object, stubValidador.Object);

        // Act
        var resultado = service.AgregarUsuario(usuario);

        // Assert
        Assert.IsTrue(resultado);
        mockRepo.Verify(r => r.Guardar(usuario), Times.Once); // Verifica que se llamó
    }

    [TestMethod]
    public void AgregarUsuario_Invalido_NoDebeGuardar()
    {
        // Arrange
        var usuario = new UsuarioIntegration { Nombre = "", Email = "invalido" };

        var stubValidador = new Mock<IValidadorUsuario>();
        stubValidador.Setup(v => v.EsValido(usuario)).Returns(false); // inválido

        var mockRepo = new Mock<IUsuarioRepositoryIntegration>();

        var service = new UsuarioService(mockRepo.Object, stubValidador.Object);

        // Act
        var resultado = service.AgregarUsuario(usuario);

        // Assert
        Assert.IsFalse(resultado);
        mockRepo.Verify(r => r.Guardar(It.IsAny<UsuarioIntegration>()), Times.Never); // No se guarda
    }
}
