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
        //This test requires the directory dir to exist in order to successfully save screenshots
        IWebDriver driver;
        string timestamp = DateTime.Now.ToString("yyyyMMddhhmmss");
        string dir = "C:/temp/screenshots/";
        string url = "https://shrouded-lowlands-66853.herokuapp.com/";
        string fname = "firstname";
        string fname16 = "firstnameabcdefg";
        string lname = "lastname";
        string title = "benevolent dictator for life";
        string titleNumbers = "benevolent dictator for 99 years";
        string email = "karl.testallthethings@gmail.com";
        string phone = "5035551212";
        string bus = "testing things";
        string add1 = "123 main st";
        string add2 = "suite 42";
        string city = "Portland";
        string zip = "97001";
        string zip4 = "9700";
        string zip24 = "970012345678901234567890";


        [Test]
        [Category("UI")]
        public void A01thruA05()
        {
            driver = new ChromeDriver();
            //A01
            driver.Url = url;
            TakeScreenshot(driver, "A01", timestamp);

            //A02
            DexcomTestPage page = new DexcomTestPage(driver);
            page.TypeLastName(lname);
            page.TypeSuffix("MD");
            page.TypeTitle(title);
            page.TypeEmail(email);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A02", timestamp);

            //A03
            page.ClearAllFields();
            page.TypeLastName(lname);
            page.TypeSuffix("MD");
            page.TypeTitle(title);
            page.TypeEmail(email);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeFirstName(fname16);
            TakeScreenshot(driver, "A03", timestamp);
            Console.WriteLine("Typed FirstName as " +fname16 );
            var recordedName = page.FirstName.GetAttribute("value");
            Console.WriteLine("Recorded FirsName as " + recordedName);

            //A04
            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeTitle(title);
            page.TypeEmail(email);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            TakeScreenshot(driver, "A04", timestamp);

            //A05
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A05", timestamp);
            driver.Close();
        }

        [Test]
        [Category("UI")]
        public void A06thruA08()
        {
            driver = new ChromeDriver();
            //A06
            driver.Url = url;

            //A07
            DexcomTestPage page = new DexcomTestPage(driver);
            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeTitle(titleNumbers);
            page.TypeEmail(email);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A07", timestamp);

            //A08
            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeEmail(email);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeTitle(title);
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A08", timestamp);
            driver.Close();
           
        }

        [Test]
        [Category("UI")]
        public void A09thruA12()
        {
            driver = new ChromeDriver();
            //A09
            driver.Url = url;

            //A10
            DexcomTestPage page = new DexcomTestPage(driver);
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeTitle(title);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeEmail("abc");
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A10", timestamp);

            //A11
            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeTitle(title);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeEmail("a@bc");
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A11", timestamp);

            //A12
            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeTitle(title);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TypeZip(zip);
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeEmail("a@b.c");
            page.SaveBtn.Click();
            TakeScreenshot(driver, "A12", timestamp);

            driver.Close();

        }

        [Test]
        [Category("UI")]
        public void A13thruA15()
        {
            driver = new ChromeDriver();
            //A13
            driver.Url = url;

            //A14
            DexcomTestPage page = new DexcomTestPage(driver);

            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeEmail(email);
            page.TypeTitle(title);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");            
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeZip(zip4);

            page.SaveBtn.Click();
            TakeScreenshot(driver, "A14", timestamp);

            page.ClearAllFields();
            page.TypeFirstName(fname);
            page.TypeLastName(lname);
            page.TypeEmail(email);
            page.TypeTitle(title);
            page.TypePhone(phone);
            page.TypeBusiness(bus);
            page.TypeAddressLn1(add1);
            page.TypeCity(city);
            page.TypeState("OR");
            page.TermsBox.Click();
            page.PrivacyBox.Click();
            page.TypeZip(zip24);

            page.SaveBtn.Click();
            TakeScreenshot(driver, "A15", timestamp);

            driver.Close();
        }


           //Save a screenshot to the directoy defined by dir
            protected void TakeScreenshot(IWebDriver driver, string stepName, string runtime)
        {
            
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(dir + stepName +"_"+ runtime + ".png", ScreenshotImageFormat.Png);

        }
    }
}
