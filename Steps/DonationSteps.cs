using BlueSkyProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject.Steps
{
    [Binding]
    public class DonationSteps
    {
        DonationPage donationPage = new DonationPage();

        [Given(@"the user clicks Donate")]
        public void GivenTheUserClicksDonate()
        {
            donationPage.ClickDonate();
        }

        [When(@"the user clicks continue to donation")]
        public void WhenTheUserClicksContinueToDonation()
        {
            donationPage.ClickContinueToDonation();
        }

        [When(@"the user clicks enter own amount button")]
        public void WhenTheUserClicksEnterOwnAmountButton()
        {
            donationPage.ClickEnterOwnAmount();
        }

        [When(@"the user enter own amount '(.*)'")]
        public void WhenTheUserOwnAmount(string intamt)
        {
            donationPage.EnterOwnAmount(intamt);
        }

        [When(@"the user enter amount '(.*)'")]
        public void WhenTheUserEnterAmount(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user selects amount '(.*)'")]
        public void WhenUserSelectsAmount(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
