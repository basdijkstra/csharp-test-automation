using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Answers
{
    [TestClass]
    public class AnswersIteration3
    {
        [TestMethod]
        public void StartBrowser_LoginAndPerformChecks_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://parabank.parasoft.com");

            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("demo");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            string currentTitle = driver.Title;

            Assert.AreEqual("ParaBank | Accounts Overview", currentTitle);

            IWebElement accountsOverviewHeader = driver.FindElement(By.XPath("//h1[@class='title']"));

            Assert.IsTrue(accountsOverviewHeader.Displayed);

            driver.Quit();
        }
    }
}
