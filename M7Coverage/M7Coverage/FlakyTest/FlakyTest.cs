using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace M7Coverage;

[TestClass]
public class FlakyTest
{
    private IWebDriver driver;

    [TestInitialize]
    public void Setup()
    {
        driver = new ChromeDriver();
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        driver.Manage().Window.Maximize();
    }

    [TestCleanup]
    public void Teardown()
    {
        driver.Quit();
    }

    [TestMethod]
    public void Login_ValidCredentials_ReturnDashboardVisible()
    {
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        driver.FindElement(By.Name("username")).SendKeys("Admin");
        driver.FindElement(By.Name("password")).SendKeys("admin123");
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        // ❌ Flaky: verificamos inmediatamente
        var dashboardTitle = driver.FindElement(By.CssSelector("h6.oxd-text--h6"));
        Assert.AreEqual("Dashboard", dashboardTitle.Text, "El Dashboard no se mostró");
    }

    [TestMethod]
    public void Stable_Login_DashboardVisible()
    {
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        driver.FindElement(By.Name("username")).SendKeys("Admin");
        driver.FindElement(By.Name("password")).SendKeys("admin123");
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        // ✅ Espera explícita para eliminar flakiness
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        var dashboardTitle = wait.Until(
            ExpectedConditions.ElementIsVisible(By.CssSelector("h6.oxd-text--h6"))
        );

        Assert.AreEqual("Dashboard", dashboardTitle.Text, "El Dashboard no se mostró");
    }
}
