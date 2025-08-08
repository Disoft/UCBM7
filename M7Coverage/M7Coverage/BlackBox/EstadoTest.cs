using GeneralLibrary.BlackBox.Estados;

namespace M7Coverage;

[TestClass]
public class EstadoTest
{
    [TestMethod]
    public void InsertarTarjeta_DesdeEstadoSinTarjeta_CambiaAConTarjeta()
    {
        var atm = new CajeroAutomatico();

        atm.InsertarTarjeta();

        Assert.AreEqual(EstadoATM.ConTarjeta, atm.Estado);
    }

    [TestMethod]
    public void IngresarPIN_DesdeEstadoConTarjeta_CambiaAAutenticado()
    {
        var atm = new CajeroAutomatico();

        atm.InsertarTarjeta();
        atm.IngresarPIN("1234");

        Assert.AreEqual(EstadoATM.Autenticado, atm.Estado);
    }

    [TestMethod]
    public void ExpulsarTarjeta_DesdeEstadoConTarjeta_CambiaASinTarjeta()
    {
        var atm = new CajeroAutomatico();

        atm.InsertarTarjeta();
        atm.ExpulsarTarjeta();

        Assert.AreEqual(EstadoATM.SinTarjeta, atm.Estado);
    }

    [TestMethod]
    public void ExpulsarTarjeta_DesdeEstadoAutenticado_CambiaASinTarjeta()
    {
        var atm = new CajeroAutomatico();

        atm.InsertarTarjeta();
        atm.IngresarPIN("1234");
        atm.ExpulsarTarjeta();

        Assert.AreEqual(EstadoATM.SinTarjeta, atm.Estado);
    }

    [TestMethod]
    public void IngresarPIN_Incorrecto_NoCambiaElEstado()
    {
        var atm = new CajeroAutomatico();

        atm.InsertarTarjeta();
        atm.IngresarPIN("9999");

        Assert.AreEqual(EstadoATM.ConTarjeta, atm.Estado);
    }
}
