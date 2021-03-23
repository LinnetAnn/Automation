using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationPractice.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
       
        [TestInitialize]
        public void RunsBeforeEveryTest()
        {
            var factory = new WebDriverFactory();
            driver = factory.Create(BrowserType.Chrome);
        }


        [TestCleanup]
        public void RunsAfterEveryTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}