using System;
using BlueSkyProject.Hooks;
using BlueSkyProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BlueSkyProject.Steps
{
    [Binding]
    public class RegistrationSteps

    {
        RegistrationPage _registrationPage = new RegistrationPage(); 

        [Given(@"I navigate to ""(.*)""")]
    public void GivenINavigates(string url)
    {

        _registrationPage.NavigateToWebsite(url);
    }
        
        [When(@"I click on register button")]

     public void WhenIClickOnRegisterButton()
        {
                _registrationPage.ClickRegister();
           
        }
        
       [When(@"I enter First Name ""(.*)""")]
        
     public void WhenIEnterFirstName(string name)
        {
                _registrationPage.EnterFirstName(name); 
        }
        
        [When(@"I enter Last Name ""(.*)""")]

     public void WhenIEnterLastName(string name)
        {
                _registrationPage.EnterLastName(name);
        }
       
        [When(@"I enter Email Address ""(.*)""")]

     public void WhenIEnterEmailAddress(string email)
        {
                _registrationPage.EnterEmailAddresse(email);
        }
        
       [When(@"I enter Phone Number ""(.*)""")]

     public void WhenIEnterPhoneNumber(Decimal number)
        {
                _registrationPage.EnterPhoneNumber("12345678911");       
        }
        
        [When(@"I enter Password ""(.*)""")]

     public void WhenIEnterPassword(string password)
        {
              _registrationPage.EnterPassword(password);
        }
        
        [When(@"I enter Confirm Password ""(.*)""")]

     public void WhenIEnterConfirmPassword(string confirmPassword)
        {
             _registrationPage.EnterConfirmPassword(confirmPassword);
        }
        
        [When(@"I enter Address ""(.*)""")]

     public void WhenIEnterAddress(string address)

        {
            _registrationPage.EnterAddress(address);
        }
        
       [When(@"I enter Town ""(.*)""")]

     public void WhenIEnterTown(string town)
        {
                _registrationPage.EnterTown(town);
        }
        
        [When(@"I enter State ""(.*)""")]

     public void WhenIEnterState(string state)
        {
                _registrationPage.EnterTown(state);
        }
        
        [When(@"I click on Create Account Button")]

     public void WhenIClickOnCreateAccountButton()
        {
                _registrationPage.ClickCreateAccount();
        }


        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_registrationPage.ThenSuccessfulMessageDisplayed());
        }


        
    }
}
