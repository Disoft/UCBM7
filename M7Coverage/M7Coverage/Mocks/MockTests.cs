using GeneralLibrary.Mocks;
using Moq;

namespace M7Coverage;

[TestClass]
public class MockTests
{
    [TestMethod]
    public void NotificarUsuario_DebeLlamarAlServicioDeCorreo()
    {
        // Arrange
        var mockEmail = new Mock<IEmailService>();
        var notificador = new Notificador(mockEmail.Object);

        // Act
        notificador.NotificarUsuario("usuario@ejemplo.com");

        // Assert
        mockEmail.Verify(e => e.EnviarCorreo("usuario@ejemplo.com", "Tienes un nuevo mensaje"), Times.Once);
    }
}
