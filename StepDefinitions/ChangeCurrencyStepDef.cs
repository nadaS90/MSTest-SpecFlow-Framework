using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using static SpecFlowBasics.HooksInitialization.Hooks;


namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class ChangeCurrencyStepDef
    {
        HomePage _homeObject;

        public ChangeCurrencyStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
        }

        [Given(@"User clicks on drop list")]
        public void GivenUserClicksOnDropList()
        {
            _homeObject.ClickChangeCurrency();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [When(@"User clicks on Euro")]
        public void WhenUserClicksOnEuro()
        {
            _homeObject.UserChooserEuro();
        }

        [Then(@"User find the price of products in Euro")]
        public void ThenUserFindThePriceOfProductsInEuro()
        {
        }

    }
}