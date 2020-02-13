using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.BasePages
{
    /***
     * Make the RequestLoanResultPage inherit from the BasePage
     */

    public class RequestLoanResultPage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        private By textfieldLoanRequestResult = By.Id("loanStatus");

        /***
         * Pass the WebDriver object to the constructor of the BasePage here
         */
        public RequestLoanResultPage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public string GetLoanRequestResult()
        {
            return selenium.GetElementText(textfieldLoanRequestResult);
        }
    }
}
