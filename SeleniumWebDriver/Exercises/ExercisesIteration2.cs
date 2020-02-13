using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration2
    {
        [TestMethod]
        public void StartBrowser_Login_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            /***
             * 1. Locate the username textfield element and type the value 'john' in it
             * 2. Locate the password textfield element and type the value 'demo' in it
             * 3. Locate the LOG IN button element and click it
             */

            driver.Quit();
        }
    }
}
