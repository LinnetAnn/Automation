using OpenQA.Selenium;
using System;

namespace AutomationPractice.Pages
{
    internal class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal bool Contains(Items  ItemToSearchFor)
        {
            switch (ItemToSearchFor)
            {
                case Items.blouse:
                   return driver.FindElement(By.XPath("//*[@title='Blouse']")).Displayed;
                    
                default:
                    throw new ArgumentOutOfRangeException("No such Item found!");
            }
        }
    }
}