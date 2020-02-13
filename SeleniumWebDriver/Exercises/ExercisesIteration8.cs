using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Exercises.Helpers;
using SeleniumWebDriver.Exercises.BasePages;

namespace SeleniumWebDriver.Exercises
{
    [TestClass]
    public class ExercisesIteration8
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

            /***
             * Make sure that you can still select a menu item
             * from the AccountsOverviewPage after you removed
             * the selectMenuItem() method from the class
             */
             
            new AccountsOverviewPage(driver)
                .SelectMenuItem("Request Loan");

            new RequestLoanPage(driver)
                .SubmitLoanRequestForAmount("10000", "100", "54321");
            
            Assert.AreEqual(
                "Denied",
                new RequestLoanResultPage(driver).GetLoanRequestResult()
            );

            /***
             * Add a method call here that selects the 'Log Out'
             * menu item from the RequestLoanResultPage.
             */
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
