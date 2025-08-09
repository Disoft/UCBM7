using GeneralLibrary.UnitTest;
using Moq;

namespace M7Coverage;

[TestClass]
public class GestorDePedidosTests
{
    [TestMethod]
    public void ProcesarPedido_ConStock_EnviaCorreo()
    {
        // Arrange

        // Stub del servicio de inventario: siempre dice que hay stock
        var stubInventario = new Mock<IInventarioService>();
        stubInventario.Setup(i => i.HayStock("ABC123")).Returns(true);

        // Mock del servicio de correo para verificar que se llama
        var mockEmail = new Mock<IEmailService>();

        var gestor = new GestorDePedidos(stubInventario.Object, mockEmail.Object);

        // Act
        var resultado = gestor.ProcesarPedido("ABC123", "cliente@ejemplo.com");

        // Assert
        Assert.IsTrue(resultado);
        mockEmail.Verify(e => e.EnviarCorreo("cliente@ejemplo.com",
            "Su pedido del producto ABC123 fue procesado."), Times.Once);
    }
}
