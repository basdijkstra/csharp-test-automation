using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration3
    {
        [TestMethod]
        public void StartBrowser_LoginAndPerformChecks_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("demo");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            /***
             * 1. Retrieve the current page title as displayed in the active tab and store it in a String variable
             * 2. Assert that the current title equals 'ParaBank | Accounts Overview'
             * 3. Retrieve the web element that shows the text 'Accounts Overview' above the list of john's accounts
             * 4. Assert that this element is visible on the page
             */

            driver.Quit();
        }
    }
}
