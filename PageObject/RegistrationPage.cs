using System;
using System.Collections.Generic;
using System.Text;
using BlueSkyProject.Hooks;
using OpenQA.Selenium;

namespace BlueSkyProject.PageObject
{
    public class RegistrationPage
    {
        public IWebDriver driver;
        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }
        private By register = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(2) > a");
        private By firstName = By.CssSelector("#firstname");
        private By lastName = By.CssSelector("#lastname");
        private By emailAddress = By.XPath("//input[@id='emailaddressreg']");
        private By phoneNumber = By.CssSelector("#telephone");
        private By passWord = By.CssSelector("#passwordreg");
        private By ConfirmPassword = By.CssSelector("#cnpassword");
        private By Address = By.CssSelector("#address");
        private By Town = By.CssSelector("#city");
        private By State = By.CssSelector("#state");
        private By createAccount = By.CssSelector("#btn_register");
        private By successMessage = By.CssSelector("#dialoguetext");


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public void ClickRegister()
        {
            driver.FindElement(register).Click();
           
        }
        public void EnterFirstName(string name)
        {
            driver.FindElement(firstName).SendKeys(name);
        }
        public void EnterLastName(string name)
        {
            driver.FindElement(lastName).SendKeys(name);
        }
        public void EnterEmailAddresse(string email)
        {
            driver.FindElement(emailAddress).SendKeys(email);
        }
        public void EnterPhoneNumber(string number)
        {
            driver.FindElement(phoneNumber).SendKeys(number);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passWord).SendKeys(password);
        }

        public void EnterConfirmPassword(string confirmPassword)
        {
            driver.FindElement(ConfirmPassword).SendKeys(confirmPassword);
        }
        public void EnterAddress(string address)
        {
            driver.FindElement(Address).SendKeys(address);
        }
        public void EnterTown(string town)
        {
            driver.FindElement(Town).SendKeys(town);
        }
        public void EnterState(string state)
        {
            driver.FindElement(State).SendKeys(state);

        }
        public void ClickCreateAccount()
        {
            driver.FindElement(createAccount).Click();
        }

        public bool ThenSuccessfulMessageDisplayed()
        {
            return driver.FindElement(successMessage).Displayed;
        }
        public bool IsTheUserOnTheLandingPage()
        {
            //This is a way to ascertain that the url is correct
            return driver.Url == "https://longrichway.com/home/register";
        }

    } 
}
         





