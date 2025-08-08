using GeneralLibrary.BlackBox.Riesgos;

namespace M7Coverage;

[TestClass]
public class RiesgoTests
{
    [TestMethod]
    [TestCategory("Alto Riesgo")]
    public void Transferencia_SinAutenticacion_LanzaExcepcion()
    {
        var cuenta = new CuentaBancaria(5000);
        cuenta.EstaAutenticado = false;

        Assert.ThrowsException<UnauthorizedAccessException>(() => cuenta.Transferir(100));
    }

    [TestMethod]
    [TestCategory("Alto Riesgo")]
    public void Transferencia_ExcedeLimitePermitido_LanzaExcepcion()
    {
        var cuenta = new CuentaBancaria(15000);
        cuenta.EstaAutenticado = true;

        Assert.ThrowsException<InvalidOperationException>(() => cuenta.Transferir(12000));
    }

    [TestMethod]
    [TestCategory("Alto Riesgo")]
    public void Transferencia_DejaSaldoNegativo_LanzaExcepcion()
    {
        var cuenta = new CuentaBancaria(300);
        cuenta.EstaAutenticado = true;

        Assert.ThrowsException<InvalidOperationException>(() => cuenta.Transferir(400));
    }

    [TestMethod]
    [TestCategory("Medio Riesgo")]
    public void Transferencia_Valida_SeEjecutaCorrectamente()
    {
        var cuenta = new CuentaBancaria(5000);
        cuenta.EstaAutenticado = true;

        var resultado = cuenta.Transferir(1000);

        Assert.IsTrue(resultado);
        Assert.AreEqual(4000, cuenta.Saldo);
    }
}
