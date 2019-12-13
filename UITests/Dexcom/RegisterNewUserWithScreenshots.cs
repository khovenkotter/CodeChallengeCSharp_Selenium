using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using DexcomCodeChallenge._Data._Models._PageObjects;
using System.Drawing.Imaging;
using System;

namespace DexcomCodeChallenge.UITests.Dexcom
{
    [TestFixture]
    public class RegisterNewUserWithScreenshots
    {
        IWebDriver driver;

        [Test]
        [Category("UI")]
        public void NavigateToTestPage()
        {
            driver = new ChromeDriver();
            
        }
        protected void TakeScreenshot(IWebDriver driver, string stepName)
        {
            
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            //ss.SaveAsFile("C:/temp/" + stepName + ".png", ImageFormat.Png);

        }
    }
}
