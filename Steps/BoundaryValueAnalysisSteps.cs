using BlueSkyProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;  
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject.Steps
{
    [Binding]
    public class BoundaryValueAnalysisSteps
    {
        BoundaryValuePage boundaryValuePage = new BoundaryValuePage();
        [Given(@"the user navigates to ""(.*)""")]
        public void GivenTheUserNavigatesTo(string url)
        {
            boundaryValuePage.NavigateToWebsite(url);
        }

        [Given(@"the user clicks Accept cookies")]
        public void GivenTheUserClicksAcceptCookies()
        {
            boundaryValuePage.ClickAcceptCookies();
        }

        [When(@"the user clicks Application/Registration")]
        public void WhenTheUserClicksApplicationRegistration()
        {
            boundaryValuePage.ClickApplication();
        }

        [When(@"the user enter Student full name'(.*)'")]
        public void WhenTheUserEnterStudentFullName(string name)
        {
            boundaryValuePage.EnterStudentFullName(name);
        }

        [When(@"the user selects student age from the drop-down menu '(.*)'")]
        public void WhenTheUserSelectsStudentAgeFromTheDrop_DownMenu(int ages)
        {
            boundaryValuePage.SelectFiveFromAgeGroup();
        }

        [When(@"the user enter Parent/Guardian name '(.*)'")]
        public void WhenTheUserEnterParentGuardianName(string gname)
        {
            boundaryValuePage.EnterGuardianName(gname);
        }

        [When(@"the user enter email address '(.*)'")]
        public void WhenTheUserEnterEmailAddress(string mail)
        {
            boundaryValuePage.EnterEmailAddress(mail);
        }

        [When(@"the user enter Parent phone with country code '(.*)'")]
        public void WhenTheUserEnterParentPhoneWithCountryCode(string number)
        {
            boundaryValuePage.EnterPhoneNumber(number);
        }

        [When(@"the user enter street address '(.*)'")]
        public void WhenTheUserEnterStreetAddress(string addy)
        {
            boundaryValuePage.EnterStreetAddress(addy);
        }

        [When(@"the user enter Apartment '(.*)'")]
        public void WhenTheUserEnterApartment(string apt)
        {
            boundaryValuePage.EnterApartment(apt);
        }


        [When(@"the user enter City '(.*)'")]
        public void WhenTheUserEnterCity(string cty)
        {
            boundaryValuePage.EnterCity(cty);
        }

        [When(@"the user enter Street/Province '(.*)'")]
        public void WhenTheUserEnterStreetProvince(string str)
        {
            boundaryValuePage.EnterProvince(str);
        }

        [When(@"the user enter Zip/Postal Code '(.*)'")]
        public void WhenTheUserEnterZipPostalCode(string pcode)
        {
            boundaryValuePage.EnterZipCode(pcode);
        }
  
        [When(@"the user select Country from the country drop-down menu '(.*)'")]
        public void WhenTheUserSelectCountryFromTheCountryDrop_DownMenu(string ctry)
        {
            boundaryValuePage.SelectCountry();
        }

        [When(@"the user click on one Course")]
        public void WhenTheUserClickOnOneCourse()
        {
          boundaryValuePage.ClickCourse();
        }

        [When(@"the user enter their experience in coding in the text box '(.*)'")]
        public void WhenTheUserEnterTheirExperienceInCodingInTheTextBox(string exp)
        {
            boundaryValuePage.EnterExperience(exp);
        }

        [When(@"the user enter Motivation in the text box '(.*)'")]
        public void WhenTheUserEnterMotivationInTheTextBox(string mtv)
        {
            boundaryValuePage.EnterMotivation(mtv);
        }

        [When(@"the user clicks Send Message button")]
        public void WhenTheUserClicksSendMessageButton()
        {
            boundaryValuePage.ClickSend();
        }

        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string message)
        {
            Assert.AreEqual(message, boundaryValuePage.GetSuccessMessageText());
        }

        //[Then(@"the user should get error message")]
        //public void ThenTheUserShouldGetErrorMessage()
        //{
        //    Assert.AreNotEqual(message, boundaryValuePage.GetSuccessMessageText());
        //}


    }
}
