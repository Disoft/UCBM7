using GeneralLibrary.UnitTest;
using Moq;

namespace M7Coverage;

[TestClass]
public class GeneradorDeInformeTests
{
    [TestMethod]
    public void ObtenerCantidadUsuarios_RetornaCantidadCorrecta()
    {
        // Arrange: crear un mock que simula carga de datos
        var mockRepo = new Mock<IUsuarioRepository>();

        // Datos simulados
        var usuariosSimulados = new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Alice" },
            new Usuario { Id = 2, Nombre = "Bob" }
        };

        // Configurar el mock
        mockRepo.Setup(repo => repo.ObtenerUsuarios()).Returns(usuariosSimulados);

        var generador = new GeneradorDeInforme(mockRepo.Object);

        // Act
        int resultado = generador.ObtenerCantidadUsuarios();

        // Assert
        Assert.AreEqual(2, resultado);
    }
}
