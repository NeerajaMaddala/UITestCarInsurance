using MMCarInsurance.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MMCarInsurance.StepDefinitions
{
    [Binding]
    public class LandingPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private LandingPage _landingPage;
        IWebDriver driver = new ChromeDriver();

        public LandingPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Given(@"I navigate to the Car Insurance")]
        public void GivenINavigateToTheCarInsurance()
        {
            driver.Navigate().GoToUrl("https://car.iselect.com.au/car/compare-car-insurance/gatewayStore");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _landingPage = new LandingPage(driver);
        }

        [When(@"User selects the Terms and conditions check box")]
        public void WhenUserSelectsTheTermsAndConditionsCheckBox()
        {
            _landingPage.SelectCheckBox();
        }

        [When(@"Click on Continue button")]
        public void WhenClickOnContinueButton()
        {
            _landingPage.ClickContinueButton();
        }

        [Then(@"the ""(.*)""  should display")]
        public void ThenTheShouldDisplay(string expectedErrorMessage)
        {
            Assert.IsTrue(_landingPage.ISFormlevelErrorMessage());
            
        }

        [When(@"User fills find your car details in car insurance Page")]
        [Then(@"User fills find your car details in car insurance Page")]
        public void WhenUserFillsFormDetailsInCarInsurancePage()
        {
            _landingPage.fillcarinsuranceform();
        }

   }
}
