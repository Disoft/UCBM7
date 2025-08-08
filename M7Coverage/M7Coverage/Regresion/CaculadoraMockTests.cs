using GeneralLibrary.Regresion;
using Moq;

namespace M7Coverage;

[TestClass]
public class CaculadoraMockTests
{
    private Mock<IDiscountRepository> repositoryMock;
    private DiscountCalculator calculator;

    [TestInitialize]
    public void Setup()
    {
        repositoryMock = new Mock<IDiscountRepository>();
        calculator = new DiscountCalculator(repositoryMock.Object);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldApplyPersonalizedDiscount_WhenCustomerHasCustomRate()
    {
        // Arrange
        string customerId = "client123";
        decimal amount = 1000m;
        repositoryMock.Setup(r => r.GetPersonalizedDiscount(customerId)).Returns(0.2m); // 20% descuento

        // Act
        var result = calculator.ApplyDiscount(customerId, amount);

        // Assert
        Assert.AreEqual(800m, result);
    }

    [TestMethod]
    public void ApplyDiscount_ShouldFallbackToDefaultRules_WhenNoCustomDiscount()
    {
        // Arrange
        string customerId = "client999";
        decimal amount = 750m;
        repositoryMock.Setup(r => r.GetPersonalizedDiscount(customerId)).Returns((decimal?)null);

        // Act
        var result = calculator.ApplyDiscount(customerId, amount);

        // Assert
        Assert.AreEqual(712.5m, result); // 5% descuento por monto
    }

    [TestMethod]
    public void ApplyDiscount_ShouldNotApplyDiscount_WhenAmountIsLow_AndNoPersonalDiscount()
    {
        // Arrange
        string customerId = "client888";
        decimal amount = 300m;
        repositoryMock.Setup(r => r.GetPersonalizedDiscount(customerId)).Returns((decimal?)null);

        // Act
        var result = calculator.ApplyDiscount(customerId, amount);

        // Assert
        Assert.AreEqual(300m, result);
    }
}
