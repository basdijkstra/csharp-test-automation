using OpenQA.Selenium;
using SeleniumWebDriver.Answers.Helpers;

namespace SeleniumWebDriver.Answers.BasePages
{
    public class RequestLoanResultPage : BasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        private By textfieldLoanRequestResult = By.Id("loanStatus");

        public RequestLoanResultPage(IWebDriver driver) : base(driver)
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
