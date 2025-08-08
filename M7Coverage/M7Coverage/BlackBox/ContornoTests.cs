using GeneralLibrary.BlackBox.Particionamiento;

namespace M7Coverage;

[TestClass]
public class ContornoTests
{
    private UsuarioBlackBox _userService;

    [TestInitialize]
    public void Setup()
    {
        _userService = new GeneralLibrary.BlackBox.Particionamiento.UsuarioBlackBox();
    }

    [DataTestMethod]
    [DataRow(18)] // Edad l�mite inferior
    [DataRow(65)] // Edad l�mite superior 
    public void PuedeRegistrarse_EdadValida_DeberiaRetornarTrue(int edad)
    {
        var resultado = _userService.PuedeRegistrarse(edad);
        Assert.IsTrue(resultado);
    }

    [DataTestMethod]
    [DataRow(17)] // Edad l�mite inferior - 1
    [DataRow(66)] // Edad l�mite superior + 1
    public void PuedeRegistrarse_EdadInvalida_DeberiaRetornarFalse(int edad)
    {
        var resultado = _userService.PuedeRegistrarse(edad);
        Assert.IsFalse(resultado);
    }


}
