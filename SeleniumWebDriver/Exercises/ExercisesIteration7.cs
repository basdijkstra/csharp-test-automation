using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Exercises.Helpers;
using SeleniumWebDriver.Exercises.Pages;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration7
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

            /***
             * Replace the methods below by the methods that you created
             * in the RequestLoanPage and RequestLoanResultPage Page Objects
             */

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
