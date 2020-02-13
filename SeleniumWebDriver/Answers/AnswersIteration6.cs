using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Answers.Helpers;

namespace SeleniumWebDriver.Answers
{
    [TestClass]
    public class AnswersIteration6
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

            selenium.Click(By.LinkText("Request Loan"));
            selenium.SendKeys(By.Id("amount"), "10000");
            selenium.SendKeys(By.Id("downPayment"), "100");
            selenium.Select(By.Id("fromAccountId"), "54321");
            selenium.Click(By.XPath("//input[@value='Apply Now']"));

            Assert.AreEqual("Denied", selenium.GetElementText(By.Id("loanStatus")));
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
