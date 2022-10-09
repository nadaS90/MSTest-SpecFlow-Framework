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

    public class S04_SearchProductAutoCompleteStepDef
    {
        P04_SearchProductPage _searchObject;
        P05_ProductDetailsPage _detailsObject;

        public S04_SearchProductAutoCompleteStepDef(IWebDriver driver)
        {
            this._searchObject = new P04_SearchProductPage(Hooks.driver);
            this._detailsObject = new P05_ProductDetailsPage(Hooks.driver);
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