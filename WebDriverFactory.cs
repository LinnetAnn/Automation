using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace AutomationResources
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser found!");
            }
        }

        private IWebDriver GetChromeDriver()
        {

            var OutputDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(OutputDir);
        }
    }
}