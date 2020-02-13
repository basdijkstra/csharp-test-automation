using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration6
    {
        private IWebDriver driver;
        private SeleniumHelpers selenium;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            selenium = new SeleniumHelpers(driver);
        }

        [TestMethod]
        public void StartBrowser_LoginAndPerformChecks_StopBrowser()
        {
            selenium.NavigateTo("http://parabank.parasoft.com");

            selenium.SendKeys(By.Name("username"), "john");
            selenium.SendKeys(By.Name("password"), "demo");
            selenium.Click(By.XPath("//input[@value='Log In']"));

            /***
             * Rewrite the actions below so they use the helper methods in the SeleniumHelpers class
             * You'll need to define one helper method yourself, to perform the dropdown select action
             * All other helpers you'll need are there already
             */

            driver.FindElement(By.LinkText("Request Loan")).Click();
            driver.FindElement(By.Id("amount")).SendKeys("10000");
            driver.FindElement(By.Id("downPayment")).SendKeys("100");
            SelectElement dropdownFromAccountId = new SelectElement(driver.FindElement(By.Id("fromAccountId")));
            dropdownFromAccountId.SelectByText("54321");
            driver.FindElement(By.XPath("//input[@value='Apply Now']")).Click();

            string result = driver.FindElement(By.Id("loanStatus")).Text;
            Assert.AreEqual("Denied", result);
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
