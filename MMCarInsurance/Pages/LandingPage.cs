
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MMCarInsurance.Pages
{
    public class LandingPage
    {
        public IWebDriver driver { get; }
        private int _waittime = 2000;
        public LandingPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //UI Elements

        public IWebElement checkBox => driver.FindElement(By.XPath("//input[@type='checkbox']/preceding::span[1]"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//button[text()='Continue']"));
        public IWebElement formlevelErrorMessage => driver.FindElement(By.XPath("//span[text()='Please select an option']"));



        //Methods
        public void NavigateToCarInsurance()
        {
            driver.Navigate().GoToUrl("https://car.iselect.com.au/car/compare-car-insurance/gatewayStore");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public void SelectCheckBox() => checkBox.Click();
        public void ClickContinueButton() => continueButton.Click();
        public bool ISFormlevelErrorMessage() => formlevelErrorMessage.Displayed;

        public void fillcarinsuranceform()
        {
            IList<IWebElement> elements = driver.FindElements(By.XPath("//input[@role='combobox']"));
            Actions action = new Actions(driver);
            elements[0].SendKeys("Mazda");
            Thread.Sleep(_waittime);
            elements[0].SendKeys(Keys.Enter);
            Thread.Sleep(_waittime);
            for (int i=1;i<=5;i++)
            {
                action.SendKeys(Keys.Enter).Build().Perform();
                Thread.Sleep(_waittime);

            }

        }
    }
}
