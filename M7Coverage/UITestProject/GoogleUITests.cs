using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UITestProject
{
    [TestClass]
    public class GoogleUITests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // opcional
            driver = new ChromeDriver(options);
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit(); // Cierra el navegador
        }

        [TestMethod]
        public void Google_HomePage_HasCorrectTitle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            string title = driver.Title;

            Assert.AreEqual("Google", title, ignoreCase: true);
        }
    }
}
