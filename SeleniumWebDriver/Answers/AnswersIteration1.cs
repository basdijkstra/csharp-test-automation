using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Answers
{
    [TestClass]
    public class AnswersIteration1
    {
        [TestMethod]
        public void StartBrowser_NavigateToParaBankHomepage_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            driver.Quit();
        }
    }
}
