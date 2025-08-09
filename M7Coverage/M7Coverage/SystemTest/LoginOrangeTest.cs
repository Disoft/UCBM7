using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace M7Coverage;

[TestClass]
public class LoginOrangeTest
{
    private IWebDriver driver;

    [TestInitialize]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Window.Maximize();
    }

    [TestMethod]
    public void Login_CredencialesValidas_MuestraDashboard()
    {
        // Navegar al sitio
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        // Ingresar usuario
        var usernameInput = driver.FindElement(By.Name("username"));
        usernameInput.SendKeys("Admin");

        // Ingresar contrase�a
        var passwordInput = driver.FindElement(By.Name("password"));
        passwordInput.SendKeys("admin123");

        // Hacer clic en el bot�n de login
        var loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));
        loginButton.Click();

        // Validar que se carga el dashboard
        var dashboardHeader = driver.FindElement(By.CssSelector("h6.oxd-text"));
        Assert.IsTrue(dashboardHeader.Text.Contains("Dashboard"));
    }

    [TestMethod]
    public void Login_CredencialesInvalidas_MuestraError()
    {
        // Navegar al sitio
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        // Ingresar usuario inv�lido
        var usernameInput = driver.FindElement(By.Name("username"));
        usernameInput.SendKeys("usuario_falso");

        // Ingresar contrase�a inv�lida
        var passwordInput = driver.FindElement(By.Name("password"));
        passwordInput.SendKeys("clave_falsa");

        // Hacer clic en el bot�n de login
        var loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));
        loginButton.Click();

        // Esperar y validar el mensaje de error
        var errorMessage = driver.FindElement(By.CssSelector(".oxd-alert-content-text"));
        Assert.IsTrue(errorMessage.Text.Contains("Invalid credentials"));
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
}
