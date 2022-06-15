using BlueSkyProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject.PageObject
{
    public class DonationPage
    {
        public IWebDriver driver;

        public DonationPage()
        {
            driver = BaseTest.driver;
        }
       
        IWebElement giving => driver.FindElement(By.XPath("//li[@id='menu-item-1473']//a[normalize-space()='Donate']"));
        IWebElement conDonate => driver.FindElement(By.XPath("//button[normalize-space()='Continue to Donation']"));
        IWebElement ownAmnt => driver.FindElement(By.XPath("(//button[normalize-space()='Enter own amount'])[1]"));
        IWebElement ownAmnt1 => driver.FindElement(By.XPath("//input[@id='give-amount']"));
        IWebElement cont => driver.FindElement(By.XPath("//button[normalize-space()='Continue']"));
        IWebElement fName => driver.FindElement(By.XPath("//input[@id='give-first']"));
        IWebElement lName => driver.FindElement(By.XPath("//input[@id='give-last']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@id='give-email']"));
        IWebElement anonym => driver.FindElement(By.XPath("//label[@for='give-anonymous-donation']"));
        IWebElement comment => driver.FindElement(By.XPath("//textarea[@id='give-comment']"));
        IWebElement stripe => driver.FindElement(By.XPath("//label[@id='give-gateway-option-stripe_checkout']"));
        IWebElement terms => driver.FindElement(By.XPath("//label[@for='give_agree_to_terms-1250']"));
        IWebElement editDon => driver.FindElement(By.XPath("//button[normalize-space()='Edit Donation']"));
        IWebElement donateNow => driver.FindElement(By.XPath("//input[@id='give-purchase-button']"));


        
        public void ClickDonate()
        {
            giving.Click();
        }

        public void ClickContinueToDonation()
        {
            conDonate.Click();
        }

        public void ClickEnterOwnAmount()
        {
            ownAmnt.Click();
        }

        public void EnterOwnAmount(string intamt)
        {
            ownAmnt1.SendKeys(intamt);
        }











    }
}






    
