using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration4
    {
        /***
         * 1. Create a private instance of the WebDriver class as a class variable
         *    (it has to be accessed by several methods in this class)
         * 2. Create a [TestInitialize] method where you start a Chrome instance and maximize it
         * 3. Create a [TestCleanup] method where you close the browser using the Quit() method
         */

        [TestMethod]
        public void StartBrowser_LoginAndPerformChecks_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("demo");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            string currentTitle = driver.Title;

            Assert.AreEqual("ParaBank | Accounts Overview", currentTitle);

            IWebElement accountsOverviewHeader = driver.FindElement(By.XPath("//h1[@class='title']"));

            Assert.IsTrue(accountsOverviewHeader.Displayed);

            driver.Quit();
        }
    }
}
