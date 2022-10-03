using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using static SpecFlowBasics.HooksInitialization.Hooks;
using Constants = SpecFlowBasics.data.Constants;



namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class ChangeCurrencyStepDef
    {
        HomePage _homeObject;
        SearchProductPage _searchObject;
        ProductDetailsPage _detailsObject;

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
         Hooks.driver.Navigate().GoToUrl("https://demo.nopcommerce.com/desktops");
         IList<IWebElement> Currency = _homeObject.Currency;
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