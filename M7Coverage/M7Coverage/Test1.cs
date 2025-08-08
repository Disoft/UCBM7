using GeneralLibrary;
using StaticAnalysis;

namespace M7Coverage
{
    [TestClass]
    public sealed class ThreadTests
    {
        LoginService loginService = new LoginService();

        //[TestMethod]
        //public void Sumar_DosNumeros_RetornaCorrecto()
        //{
        //    var calc = new Calculadora();
        //    int resultado = calc.Sumar(3, 2);

        //    Assert.AreEqual(5, resultado);
        //}

        //[TestMethod]
        //public void EvaluarNumero_NumeroPositivo_DeberiaRetornarPositivo()
        //{
        //    var calc = new Calculadora();
        //    var resultado = calc.EvaluarNumero(5);
        //    Assert.AreEqual("Positivo", resultado);
        //}

        //[TestMethod]
        //public void EvaluarNumero_NumeroCero_DeberiaRetornarNoPositivo()
        //{
        //    var calc = new Calculadora();
        //    var resultado = calc.EvaluarNumero(0);
        //    Assert.AreEqual("No positivo", resultado);
        //}

        //[TestMethod]
        //public void PositivoPar() =>
        //    Assert.AreEqual("Positivo par", new Verificador().ClasificarNumero(2));

        //[TestMethod]
        //public void PositivoImpar() =>
        //    Assert.AreEqual("Positivo impar", new Verificador().ClasificarNumero(3));

        //[TestMethod]
        //public void Negativo() =>
        //    Assert.AreEqual("Negativo", new Verificador().ClasificarNumero(-2));

        //[TestMethod]
        //public void Cero() =>
        //   Assert.AreEqual("Cero", new Verificador().ClasificarNumero(0));

        //COnditional testing
        //[TestMethod]
        //public void UrgenteYInternacional() =>
        //      Assert.AreEqual("Exprés Internacional", new EnvioService().DeterminarTipoEnvio(true, true));

        //[TestMethod]
        //public void UrgenteNacional() =>
        //    Assert.AreEqual("Exprés Nacional", new EnvioService().DeterminarTipoEnvio(true, false));

        //[TestMethod]
        //public void InternacionalNormal() =>
        //    Assert.AreEqual("Normal Internacional", new EnvioService().DeterminarTipoEnvio(false, true));

        //[TestMethod]
        //public void NacionalNormal() =>
        //    Assert.AreEqual("Normal Nacional", new EnvioService().DeterminarTipoEnvio(false, false));

        [TestMethod]
        public void AmbosPositivos()
        {
            var calc = new GeneralLibrary.Calculadora();
            Assert.AreEqual(9, calc.Calcular(4, 5)); // Usa def interna
        }

        [TestMethod]
        public void UnoNegativo()
        {
            var calc = new GeneralLibrary.Calculadora();
            Assert.AreEqual(0, calc.Calcular(-1, 5)); // Usa def externa
        }
    }
}
