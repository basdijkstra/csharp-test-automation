using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.Pages
{
    public class RequestLoanResultPage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        /***
         * Define a private object of type By that represent the loan request result as shown on screen
         */

        public RequestLoanResultPage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public string GetLoanRequestResult()
        {
            /***
             * Change the implementation of this method so that it returns
             * the actual loan request result as shown on screen
             */

            return "";
        }
    }
}
