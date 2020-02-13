using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.Pages
{
    public class RequestLoanPage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        /***
         * Create new By objects for the following four page elements:
         * - textfield for the loan amount
         * - textfield for the down payment
         * - dropdown for the from account id
         * - button Apply Now
         */

        public RequestLoanPage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        /***
         * Write a method SubmitLoanRequestForAmount that takes three parameters
         * (loan amount, down payment amount and from account ID) and fills in the
         * form accordingly. Use the locators defined above
         */
    }
}
