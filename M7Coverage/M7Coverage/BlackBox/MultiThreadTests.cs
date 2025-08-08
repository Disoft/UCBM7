using GeneralLibrary.BlackBox.Subprocesos;

namespace M7Coverage;

[TestClass]
public class MultiThreadTests
{
    [TestMethod]
    public void Incrementar_DeberiaSerCorrecto_ConVariosHilos()
    {
        // Arrange
        var contador = new ContadorInseguro();
        int numeroHilos = 10;
        int incrementosPorHilo = 1000;
        int totalEsperado = numeroHilos * incrementosPorHilo;

        // Act
        Parallel.For(0, numeroHilos, i =>
        {
            for (int j = 0; j < incrementosPorHilo; j++)
            {
                contador.Incrementar();
            }
        });

        // Assert
        int resultadoFinal = contador.ObtenerValor();
        Assert.AreEqual(totalEsperado, resultadoFinal);
    }
}
