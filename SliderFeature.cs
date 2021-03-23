using AutomationResources;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPractice.Tests
{
    [TestClass]

    [TestCategory("SliderFeature")]
    public class SliderFeature : BaseTest
    {
        [TestMethod]
        [Description("Validate that slider changes images.")]
        [TestProperty("Author","Linnet")]
        public void TCID3()
        {
            Pages.AutomationPracticePage HomePage = new Pages.AutomationPracticePage(driver);
            HomePage.GoToSite();
            var currentImage = HomePage.slider.CurrentImage;
            HomePage.slider.ClickNextButton();
            var nextImage = HomePage.slider.CurrentImage;
           Assert.AreNotEqual(currentImage,nextImage,"The slider is not working.");
        }
    }
}
