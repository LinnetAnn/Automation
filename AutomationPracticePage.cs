using OpenQA.Selenium;
using System;

namespace AutomationPractice.Pages
{
    internal class AutomationPracticePage 
    {
     
        public AutomationPracticePage(IWebDriver driver)
        {
            Driver = driver;
            slider = new Slider(driver);

        }
        private readonly string PageTitle = "My Store";
       
        public IWebDriver Driver;
        public IWebElement SearchElt => Driver.FindElement(By.Id("search_query_top"));
        public bool IsVisible
        {
            get {
                return Driver.Title.Contains(PageTitle); 
            }
            internal set
            {
            }
        }
     
        public Slider slider { get; internal set; }

        internal void GoToSite()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        internal SearchPage Search(string Item)
        {

            SearchElt.Clear();
            SearchElt.SendKeys(Item);
            SearchElt.Submit();
            return new SearchPage(Driver);
        }
    }
}