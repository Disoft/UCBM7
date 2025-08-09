using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace M7Coverage;

[TestClass]
public class AddEmployeeTests
{
    private IWebDriver driver;
    private WebDriverWait wait;

    [TestInitialize]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    [TestMethod]
    public void AddEmployee_ShouldSucceed()
    {
        // Paso 1: Login
        driver.FindElement(By.Name("username")).SendKeys("Admin");
        driver.FindElement(By.Name("password")).SendKeys("admin123");
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        // Paso 2: Ir al módulo PIM
        driver.FindElement(By.XPath("//span[text()='PIM']")).Click();

        // Paso 3: Clic en "Add Employee"
        //driver.FindElement(By.XPath("//a[contains(@href,'pim/addEmployee')]")).Click();
        driver.FindElement(By.XPath("//button[normalize-space()='Add']")).Click();

        // Paso 4: Ingresar nombre y apellido
        driver.FindElement(By.Name("firstName")).SendKeys("Juan");
        driver.FindElement(By.Name("lastName")).SendKeys("Pérez");

        // Paso 5: Guardar
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        // Paso 6: Verificar que estamos en la ficha del nuevo empleado
        //var header = driver.FindElement(By.CssSelector("h6")).Text;
        var header = wait.Until(driver => driver.FindElement(By.XPath("//h6[text()='Personal Details']")));
        Assert.AreEqual("Personal Details", header.Text);
    }

    [TestCleanup]
    public void Cleanup()
    {
        driver.Quit();
    }
}
