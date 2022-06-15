using BlueSkyProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject.PageObject
{
    public class BoundaryValuePage
    {

        public IWebDriver driver;

        public BoundaryValuePage()
        {
            driver = BaseTest.driver;
        }
        //private By cookies = By.XPath("//a[@id='cookie_action_close_header']");
        IWebElement cookies => driver.FindElement(By.XPath("//a[@id='cookie_action_close_header']"));
        private By apply = By.XPath("//li[@id='menu-item-1431']//a");
        private By fullName = By.XPath("//input[@id='forminator-field-name-1']");
        //private By age = By.CssSelector("#select2-forminator-form-1533__field--select-1-container");

        private By parentName = By.XPath("//input[@id='forminator-field-name-2']");
        private By email = By.XPath("//input[@id='forminator-field-email-1']");
        private By phone = By.XPath("//input[@id='forminator-field-phone-1']");
        private By street = By.XPath("//input[@id='forminator-field-street_address-address-1']");
        private By apartment = By.XPath("//input[@id='forminator-field-address_line-address-1']");
        private By city = By.XPath("//input[@id='forminator-field-cityaddress-1']");
        private By province = By.XPath("//input[@id='forminator-field-state-address-1']");
        private By zipCode = By.XPath("//input[@id='forminator-field-zip-address-1']");
        // private By country = By.XPath("//div[@role='group']");
        private By courses = By.XPath("//label[@title='Javascript 2 (Saturdays @4-5pm from Sat 04/06 for 4 weeks)']//span[@class='forminator-checkbox-box']");
        //private By courses1 = By.XPath("//*[@id='forminator - checkbox - group - 62a1f9eb64d34 - label']");
        private By experience = By.XPath("//textarea[@id='forminator-field-textarea-1']");
        private By motivation = By.XPath("//textarea[@id='forminator-field-textarea-2']");
        private By sendButton = By.XPath("//button[@class='forminator-button forminator-button-submit']");
        //private By successMsg = By.XPath("//*[@id='forminator - module - 1533']/div[1]/p");
        //private By message = By.XPath("div[class='forminator-response-message forminator-show forminator-success']");
        IWebElement successMessage => driver.FindElement(By.CssSelector(".forminator-response-message.forminator-show.forminator-success"));

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public void ClickAcceptCookies()
        {
            //driver.FindElement(cookies).Click();
            cookies.Click();
        }
        public void ClickApplication()
        {
            driver.FindElement(apply).Click();
        }
        public void EnterStudentFullName(string name)
        {
            driver.FindElement(fullName).SendKeys(name);
        }

        public void SelectFiveFromAgeGroup()
        {
            IWebElement age = driver.FindElement(By.CssSelector("#forminator-form-1533__field--select-1"));
            SelectElement select = new SelectElement(age);
            select.SelectByValue("5");
        }
        public void EnterGuardianName(string gname)
        {
            driver.FindElement(parentName).SendKeys(gname);
        }

        public void EnterEmailAddress(string mail)
        {
            driver.FindElement(email).SendKeys(mail);
        }
        public void EnterPhoneNumber(string number)
        {
            driver.FindElement(phone).SendKeys(number);
        }
        public void EnterStreetAddress(string addy)
        {
            driver.FindElement(street).SendKeys(addy);
        }
        public void EnterApartment(string apt)
        {
            driver.FindElement(apartment).SendKeys(apt);
        }
        public void EnterCity(string cty)
        {
            driver.FindElement(city).SendKeys(cty);
        }
        public void EnterProvince(string str)
        {
            driver.FindElement(province).SendKeys(str);
        }
        public void EnterZipCode(string pcode)
        {
            driver.FindElement(zipCode).SendKeys(pcode);
        }
        public void SelectCountry()
        {
            IWebElement country = driver.FindElement(By.CssSelector("#forminator-form-1533__field--address-1"));
            SelectElement select = new SelectElement(country);
            select.SelectByValue("Uzbekistan");
        }
        public void ClickCourse()
        {
            driver.FindElement(courses).Click();
        }
        public void EnterExperience(string exp)
        {
            driver.FindElement(experience).SendKeys(exp);
        }
        public void EnterMotivation(string mtv)
        {
            driver.FindElement(motivation).SendKeys(mtv);
        }
        public void ClickSend()
        {
            driver.FindElement(sendButton).Click();
        }

        public string GetSuccessMessageText()
        {
            return successMessage.Text;
        }


        
       

    }
}

