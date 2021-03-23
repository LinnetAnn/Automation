using OpenQA.Selenium;
using System;

namespace AutomationPractice.Pages
{
    public class AutomationPracticeContactPage
    {
        private IWebDriver driver;
        private string pageTitle= "Contact us - My Store";


        public AutomationPracticeContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsVisible
        { 
            get
            {
                try
                {
                    return driver.Title.Contains(pageTitle);
                }
                catch (Exception)
                {

                    return false;
                }

               
            } 
            internal set 
            { } 
        }

        internal void GoToSite()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
           

    }
}
}