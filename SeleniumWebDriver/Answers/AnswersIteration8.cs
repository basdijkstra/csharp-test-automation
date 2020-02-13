using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Answers.Helpers;
using SeleniumWebDriver.Answers.BasePages;

namespace SeleniumWebDriver.Answers
{
    [TestClass]
    public class AnswersIteration8
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
        public void LoginAndRequestLoan()
        {
            new LoginPage(driver)
                .Load()
                .LoginAs("john", "demo");

            new AccountsOverviewPage(driver)
                .SelectMenuItem("Request Loan");

            new RequestLoanPage(driver)
                .SubmitLoanRequestForAmount("10000", "100", "54321");
            
            Assert.AreEqual(
                "Denied",
                new RequestLoanResultPage(driver).GetLoanRequestResult()
            );

            new RequestLoanResultPage(driver)
                .SelectMenuItem("Log Out");
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
