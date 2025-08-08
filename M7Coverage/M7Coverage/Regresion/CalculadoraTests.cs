using GeneralLibrary.Regresion;

namespace M7Coverage;

[TestClass]
public class CalculadoraTests
{
    private CalculadoraDeDescuentos calculator;

    [TestInitialize]
    public void Setup()
    {
        calculator = new CalculadoraDeDescuentos();
    }

    [TestMethod]
    public void ApplyDiscount_ShouldApplyPersonalizedDiscount_WhenCustomerHasCustomRate()
    {
        // Arrange
        decimal amount = 1000m;

        // Act
        var result = calculator.ApplyDiscount(amount);

        // Assert
        Assert.AreEqual(900m, result);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldFallbackToDefaultRules_WhenNoCustomDiscount()
    {
        // Arrange
        decimal amount = 750m;
        
        // Act
        var result = calculator.ApplyDiscount(amount);

        // Assert
        Assert.AreEqual(712.5m, result); // 5% descuento por monto
    }

    [TestMethod]
    public void ApplyDiscount_ShouldNotApplyDiscount_WhenAmountIsLow_AndNoPersonalDiscount()
    {
        // Arrange
        decimal amount = 300m;

        // Act
        var result = calculator.ApplyDiscount(amount);

        // Assert
        Assert.AreEqual(300m, result);
    }
}
