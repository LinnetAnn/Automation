using OpenQA.Selenium;
using System;

namespace AutomationPractice.Pages
{
    public class Slider
    {
        public Slider(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        public string CurrentImage => Driver.FindElement(By.Id("homeslider")).GetAttribute("style");

        
        internal void ClickNextButton()
        {
            var NextButton = Driver.FindElement(By.ClassName("bx-next"));
            NextButton.Click();
        }
    }
}