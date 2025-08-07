using GeneralLibrary;
using System.ComponentModel.DataAnnotations;

namespace M7Coverage;

[TestClass]
public class CoverageTest
{
    //Statement Coverage
    [TestMethod]
    public void Sumar_DosNumeros_RetornaSumaCorrecta()
    {
        var calc = new Calculadora();
        int resultado = calc.Sumar(3, 2);
        Assert.AreEqual(5, resultado);
    }

    //Branch Coverage
    [TestMethod]
    public void EvaluarNumero_NumeroPositivo_DeberiaRetornarPositivo()
    {
        var calc = new Calculadora();
        var resultado = calc.EvaluarNumero(5);
        Assert.AreEqual("Positivo", resultado);
    }

    [TestMethod]
    public void EvaluarNumero_NumeroCero_DeberiaRetornarNoPositivo()
    {
        var calc = new Calculadora();
        var resultado = calc.EvaluarNumero(0);
        Assert.AreEqual("No positivo", resultado);
    }

    //Path Coverage
    [TestMethod]
    public void Evaluar_EdadMayor18_ConPermiso_DeberiaAprobar()
    {
        var val = new Validador();
        var resultado = val.Evaluar(20, true);
        Assert.AreEqual("Aprobado", resultado);
    }

    [TestMethod]
    public void Evaluar_EdadMayor18_SinPermiso_DeberiaSolicitarPermiso()
    {
        var val = new Validador();
        var resultado = val.Evaluar(20, false);
        Assert.AreEqual("Permiso requerido", resultado);
    }

    [TestMethod]
    public void Evaluar_EdadMenor18_DeberiaRechazar()
    {
        var val = new Validador();
        var resultado = val.Evaluar(15, false);
        Assert.AreEqual("Menor de edad", resultado);
    }

    //Conditional Testing
    [TestMethod]
    public void Acceso_ConPermisoYAdministrador_DeberiaConceder()
    {
        var val = new ValidadorCondicional();
        var resultado = val.EvaluarAcceso(true, true);
        Assert.AreEqual("Acceso concedido", resultado);
    }

    [TestMethod]
    public void Acceso_ConPermisoPeroNoAdmin_DeberiaDenegar()
    {
        var val = new ValidadorCondicional();
        var resultado = val.EvaluarAcceso(true, false);
        Assert.AreEqual("Acceso denegado", resultado);
    }

    [TestMethod]
    public void Acceso_SinPermisoPeroAdmin_DeberiaDenegar()
    {
        var val = new ValidadorCondicional();
        var resultado = val.EvaluarAcceso(false, true);
        Assert.AreEqual("Acceso denegado", resultado);
    }

    [TestMethod]
    public void Acceso_SinPermisoNiAdmin_DeberiaDenegar()
    {
        var val = new ValidadorCondicional();
        var resultado = val.EvaluarAcceso(false, false);
        Assert.AreEqual("Acceso denegado", resultado);
    }

    //Data flow testing
    [TestMethod]
    [ExpectedException(typeof(System.Exception))]
    public void CalcularResultado_MultiplicarFalse_DebeFallarPorXNoInicializada()
    {
        var op = new Operaciones();
        var resultado = op.CalcularResultado(false);
    }

    [TestMethod]
    public void CalcularResultado_MultiplicarTrue_DebeCalcularCorrectamente()
    {
        var op = new Operaciones();
        var resultado = op.CalcularResultado(true);
        Assert.AreEqual(7, resultado); // 5 + 2
    }

    /*PATH COVERAGE*/
    public class VerificadorTests
    {
        [TestMethod]
        public void PositivoPar() =>
            Assert.AreEqual("Positivo par", new Verificador().ClasificarNumero(4));

        [TestMethod]
        public void PositivoImpar() =>
            Assert.AreEqual("Positivo impar", new Verificador().ClasificarNumero(3));

        [TestMethod]
        public void Negativo() =>
            Assert.AreEqual("Negativo", new Verificador().ClasificarNumero(-1));

        [TestMethod]
        public void Cero() =>
            Assert.AreEqual("Cero", new Verificador().ClasificarNumero(0));
    }

    // CONDITIONAL TESTING
    [TestClass]
    public class EnvioServiceTests
    {
        [TestMethod]
        public void UrgenteYInternacional() =>
            Assert.AreEqual("Exprés Internacional", new EnvioService().DeterminarTipoEnvio(true, true));

        [TestMethod]
        public void UrgenteNacional() =>
            Assert.AreEqual("Exprés Nacional", new EnvioService().DeterminarTipoEnvio(true, false));

        [TestMethod]
        public void InternacionalNormal() =>
            Assert.AreEqual("Normal Internacional", new EnvioService().DeterminarTipoEnvio(false, true));

        [TestMethod]
        public void NacionalNormal() =>
            Assert.AreEqual("Normal Nacional", new EnvioService().DeterminarTipoEnvio(false, false));
    }

    //DATA FLOW TESTING
    [TestClass]
    public class CalculadoraTests
    {
        [TestMethod]
        public void AmbosPositivos()
        {
            var calc = new Calculadora();
            Assert.AreEqual(9, calc.Calcular(4, 5)); // Usa def interna
        }

        [TestMethod]
        public void UnoNegativo()
        {
            var calc = new Calculadora();
            Assert.AreEqual(0, calc.Calcular(-1, 5)); // Usa def externa
        }
    }
}
