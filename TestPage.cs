using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AutomationResources;

namespace AutomationPractice.Tests
{
    [TestClass]
    public class TestPage : BaseTest
    {
      
        [TestCategory("Searching Feature")]
        
        [TestMethod]
        [Description("Checks to make sure search functionality works.")]
        [TestProperty("Author","Linnet")]
        public void TCID1()
        {
            string stringToSearch = "blouse";
            Pages.AutomationPracticePage AutomationPage = new Pages.AutomationPracticePage(driver);
            AutomationPage.GoToSite();
            Assert.IsTrue(AutomationPage.IsVisible,"Page not visible!");
            Pages.SearchPage searchPage =  AutomationPage.Search(stringToSearch);
            Assert.IsTrue(searchPage.Contains(Items.blouse),"Item not found!"); 
        }

    }
}
