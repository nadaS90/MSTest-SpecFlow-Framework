using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using static SpecFlowBasics.HooksInitialization.Hooks;
using Constants = SpecFlowBasics.data.Constants;



namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class S03_ChangeCurrencyStepDef
    {
        P03_HomePage _homeObject;
        CommonLocators _commonObject;

        public S03_ChangeCurrencyStepDef(IWebDriver driver)
        {
            this._homeObject = new P03_HomePage(Hooks.driver);
            this._commonObject = new CommonLocators(Hooks.driver);
        }

        [Given(@"User clicks on drop list")]
        public void GivenUserClicksOnDropList()
        {
            _commonObject.ClickChangeCurrency();
        }

        [When(@"User clicks on Euro")]
        public void WhenUserClicksOnEuro()
        {
            _commonObject.UserChooserEuro();
        }

        [Then(@"User find the price of products in Euro")]
        public void ThenUserFindThePriceOfProductsInEuro()
        {
         Hooks.driver.Navigate().GoToUrl("https://demo.nopcommerce.com/desktops");
         IList<IWebElement> Currency = _commonObject.Currency;
         int count = Currency.Count;
         Console.WriteLine("num of elements: "+ count);

         for (int i = 0; i < count; i++)
         {
             String ActualPrice = Currency[i].Text;
             Assert.IsTrue(ActualPrice.Contains("€"));
             Console.WriteLine(ActualPrice);
         }

        }

    }
}