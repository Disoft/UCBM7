using GeneralLibrary.BlackBox.Particionamiento;

namespace M7Coverage;

[TestClass]
public class ParticionamientoTests
{
    private UsuarioBlackBox _userService;

    [TestInitialize]
    public void Setup()
    {
        _userService = new GeneralLibrary.BlackBox.Particionamiento.UsuarioBlackBox();
    }

    // Pruebas de particionamiento para el método PuedeRegistrarse
    [DataTestMethod]
    [DataRow(18)] // Edad límite inferior
    [DataRow(35)]
    [DataRow(65)] 
    public void PuedeRegistrarse_EdadValida_DeberiaRetornarTrue(int edad)
    {
        var resultado = _userService.PuedeRegistrarse(edad);

        Assert.AreEqual(true, resultado);

        Assert.IsTrue(resultado);
    }

    [TestMethod]
    public void PuedeRegistrarse_EdadInvalidaInferior_DeberiaRetornarFalse()
    {
        int edad = 17; // Edad menor a 18

        var resultado = _userService.PuedeRegistrarse(edad);

        Assert.IsFalse(resultado);
    }

    [TestMethod]
    public void PuedeRegistrarse_EdadInvalidaSuperior_DeberiaRetornarFalse()
    {
        int edad = 66; 

        var resultado = _userService.PuedeRegistrarse(edad);

        Assert.IsFalse(resultado);
    }
}
