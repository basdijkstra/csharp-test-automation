using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration5
    {
        private IWebDriver driver;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void StartBrowser_LoginAndPerformChecks_StopBrowser()
        {
            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("demo");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            /***
             * 1. Continue the test by clicking the link with text 'Request Loan'
             * 2. Locate the Loan Amount textfield and send the text '10000' to it
             * 3. Locate the Down Payment textfield and send the text '100' to it
             * 4. Create a new Select element from the dropdown From Account Id
             * 5. Select the option '54321' from the dropdown using its visible text
             * 6. Locate the Apply Now button and click it
             * 7. Retrieve the text of the element displaying the loan application result
             * 8. Assert that this text is equal to 'Denied'
             */
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
