using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPractice.Tests
{
    [TestClass]
    public class ContactUsFeatcure : BaseTest
    {
        [TestCategory("Contact Feature")]


        [TestMethod]
        [Description("Test whether Contact Us Feature works properly")]
        [TestProperty("Author", "Linnet")]
        public void TCID2()
        {
            Pages.AutomationPracticeContactPage AutomationPracticeContactPg = new Pages.AutomationPracticeContactPage(driver);
            AutomationPracticeContactPg.GoToSite();
            Assert.IsTrue(AutomationPracticeContactPg.IsVisible, "The Contact Us Page did not open successfully!");

        }

    }
}
