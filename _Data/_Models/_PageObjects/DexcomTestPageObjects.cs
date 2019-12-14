using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DexcomCodeChallenge._Data._Models._PageObjects
{
    public class DexcomTestPage
    {
        IWebDriver _driver;

        public DexcomTestPage(IWebDriver driver)
        {
            _driver = driver;            
        }

        public IWebElement FirstName => _driver.FindElement(By.Id("user_first_name"));
        public IWebElement LastName => _driver.FindElement(By.Id("user_last_name"));
        public IWebElement Suffix => _driver.FindElement(By.Id("user_suffix"));
        public IWebElement Title => _driver.FindElement(By.Id("user_title"));
        public IWebElement Email => _driver.FindElement(By.Id("user_email"));
        public IWebElement Phone => _driver.FindElement(By.Id("user_phone_number"));
        public IWebElement Business => _driver.FindElement(By.Id("user_business_name"));
        public IWebElement AddressLn1 => _driver.FindElement(By.Id("user_address_1"));
        public IWebElement AddressLn2 => _driver.FindElement(By.Id("user_address_2"));
        public IWebElement City => _driver.FindElement(By.Id("user_city"));
        public IWebElement State => _driver.FindElement(By.Id("user_state"));
        public IWebElement Zip => _driver.FindElement(By.Id("user_zip"));
        public IWebElement TermsBox => _driver.FindElement(By.Id("user_agree_1"));
        public IWebElement PrivacyBox => _driver.FindElement(By.Id("user_agree_2"));
        public IWebElement SaveBtn => _driver.FindElement(By.Name("commit"));

        #region Fill Out Fields
        public void TypeFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }
        public void TypeLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }
        public void TypeTitle(string title)
        {
            Title.SendKeys(title);
        }
        public void TypeEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void TypePhone(string phone)
        {
            Phone.SendKeys(phone);
        }
        public void TypeBusiness(string business)
        {
            Business.SendKeys(business);
        }
        public void TypeAddressLn1(string addressLn1)
        {
            AddressLn1.SendKeys(addressLn1);
        }
        public void TypeAddressLn2(string addressLn2)
        {
            AddressLn2.SendKeys(addressLn2);
        }
        public void TypeCity(string city)
        {
            City.SendKeys(city);
        }
        public void TypeZip(string zip)
        {
            Zip.SendKeys(zip);
        }
      public void TypeState(string state)
        {
            State.SendKeys(state);
        }

    public void PickState(string state)
        {
            var selectState = new SelectElement(State);
            selectState.SelectByText(state);                
        }
        public void TypeSuffix(string suffix)
        {
            Suffix.SendKeys(suffix);
        }

        public void PickSuffix(string suffix)
        {
            var selectSuffix = new SelectElement(Suffix);
            selectSuffix.SelectByText(suffix);
        }

        public void Check(IWebElement checkbox, Boolean check)
        {
            if(!check && checkbox.Selected)
            {
                checkbox.Click();
            }
        }

        public void Uncheck(IWebElement checkbox, Boolean check)
        {
            if(check && checkbox.Selected)
            {
                checkbox.Click();
            }
        }
        #endregion
        public void ClearAllFields()
        {
            FirstName.Clear();
            LastName.Clear();
            PickSuffix("");
            Title.Clear();
            Email.Clear();
            Phone.Clear();
            Business.Clear();
            AddressLn1.Clear();
            AddressLn2.Clear();
            City.Clear();
            PickState("");
            Zip.Clear();
            Uncheck(TermsBox, true);
            Uncheck(PrivacyBox, true);            
        }

    }
}
