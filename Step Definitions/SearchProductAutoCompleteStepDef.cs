using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.data;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using Constants = SpecFlowBasics.data.Constants;


namespace SpecFlowBasics.StepDefinitions
{
    [Binding]

    public class SearchProductAutoCompleteStepDef
    {
        SearchProductPage _searchObject;
        ProductDetailsPage _detailsObject;

        public SearchProductAutoCompleteStepDef(IWebDriver driver)
        {
            this._searchObject = new SearchProductPage(Hooks.driver);
            this._detailsObject = new ProductDetailsPage(Hooks.driver);
        }



        [Given(@"User type part of product name")]
        public void GivenUserTypePartOfProductName()
        {
            _searchObject.productSearchWithAutoComplete(Constants.ProductPartName);
        }


        [Then(@"User find the product and relative products")]
        public void ThenUserFindTheProductAndRelativeProducts()
        {
            Assert.IsTrue(_detailsObject.ProductName.Text.Contains(Constants.producrName));

        }

    }
}