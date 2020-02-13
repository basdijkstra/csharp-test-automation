using System;
using OpenQA.Selenium;
using WebDriverWait = OpenQA.Selenium.Support.UI.WebDriverWait;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Exercises.Helpers
{
    public class SeleniumHelpers
    {
        private IWebDriver _driver;

        public SeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        // Tries to send the given input string to the element specified taking into account the predefined timeout
        // Catches and handles exceptions that might occur
        public void SendKeys(By by, string valueToType)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.SendKeys(): element located by {by.ToString()} could not be located within 10 seconds.");
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                // find element again and retry
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(by));
                _driver.FindElement(by).Clear();
                _driver.FindElement(by).SendKeys(valueToType);
            }
        }

        // Tries to click an element taking into account a predefined timeout
        // This can generate a variety of exception that are all handled in this method
        public void Click(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(by));
                _driver.FindElement(by).Click();
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.Click(): element located by {by.ToString()} could not be located within 10 seconds.");
            }
        }

        public void Select(By by, string valueToSelect)
        {
            /***
             * Implement this helper method so that it first waits for the select element to be clickable
             * Then perform the select by visible text action like before
             * Use proper exception handling as well in case there's a timeout
             */

        }

        // Returns whether an element is visible
        // Takes into account a predefined timeout
        // Logs to HTML if the element is not present and visible after this timeout
        public bool ElementIsVisible(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible((by)));
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        // Waits for an element to be clickable (visible AND enabled)
        // Takes into account a predefined timeout
        // Preferred method to be used for determining whether a page has been loaded
        // See for example all Page Object constructors
        public bool WaitForElementOnPageLoad(By by)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        // Returns the value of the text property for the specified element
        // Mostly used for retrieving values for input elements (text boxes)
        // Catches and handles exceptions that might occur
        public string GetElementText(By by)
        {
            string returnValue = "";

            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(by));
                returnValue = _driver.FindElement(by).Text;
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Assert.Fail($"Exception occurred in SeleniumHelper.GetElementText(): element located by {by.ToString()} could not be located within 10 seconds.");
            }

            return returnValue;
        }

        public bool TitleIsEqualTo(string expectedTitle)
        {
            try
            {
                new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.TitleIs(expectedTitle));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
