using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration5
    {
        IWebDriver driver;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_AssertOnResultPage_StopBrowser()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Thomsons Online Benefits");

            driver.FindElement(By.Name("btnK")).Click();

            string currentTitle = driver.Title;

            Assert.AreEqual("Thomsons Online Benefits - Google zoeken", currentTitle);

            IWebElement resultsElement = driver.FindElement(By.Id("resultStats"));

            Assert.IsTrue(resultsElement.Displayed);
        }

        [TestMethod]
        public void HandleDropdown()
        {
            driver.Navigate().GoToUrl("https://html.com/tags/select/");

            SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("(//select)[1]")));
            dropdown.SelectByText("Chilean flamingo");

            Assert.AreEqual("Chilean flamingo", dropdown.SelectedOption.Text);
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
