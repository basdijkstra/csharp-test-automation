using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Answers
{
    [TestClass]
    public class AnswersIteration5
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
