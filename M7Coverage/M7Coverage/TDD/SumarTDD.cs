namespace M7Coverage;

[TestClass]
public class SumarTDD
{
    [TestMethod]
    public void Sumar_DosNumeros_RetornaSuma()
    {
        var calc = new CalculadoraTDD();
        var a = 5;
        var b = 3;
        var resultadoEsperado = 8;

        var resultadoActual = calc.Sumar(a, b);

        Assert.AreEqual(resultadoEsperado, resultadoActual, "La suma de {0} y {1} debería ser {2}", a, b, resultadoEsperado);
    }
}
