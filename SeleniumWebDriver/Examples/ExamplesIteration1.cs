using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration1
    {
        [TestMethod]
        public void StartBrowser_NavigateToGoogleHomepage_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.Quit();
        }
    }
}
