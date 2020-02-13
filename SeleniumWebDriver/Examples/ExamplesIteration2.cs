using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration2
    {
        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Thomsons Online Benefits");

            driver.FindElement(By.Name("btnK")).Click();

            driver.Quit();
        }
    }
}
