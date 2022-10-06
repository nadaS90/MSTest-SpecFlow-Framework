using System;
using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.data;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowBasics
{
    [Binding]

    public class AddReviewStepDef
    {
        RegisterPage _registerObject;
        CommonLocators _commonObject;
        SearchProductPage _searchObject;
        ProductDetailsPage _detailsObject;
        AddReviewPage _reviewObject;



        static string RegisteredEmail = "";

        public AddReviewStepDef(IWebDriver driver)
        {
            this._registerObject = new RegisterPage(Hooks.driver);
            this._commonObject = new CommonLocators(Hooks.driver);
            this._searchObject = new SearchProductPage(Hooks.driver);
            this._detailsObject = new ProductDetailsPage(Hooks.driver);
            this._reviewObject = new AddReviewPage(Hooks.driver);


        }

        [Given(@"User Register to the system")]
        public void GivenUserRegisterToTheSystem()
        {
            _commonObject.ClickRegisterLink();
            _registerObject.UserSelectGender();
            _registerObject.UserAddFandLname(Constants.FName, Constants.LName);
            RegisteredEmail = Constants.Email;
            _registerObject.UserAddEmail(RegisteredEmail);
            _registerObject.UserAddPassword(Constants.Password);
            _registerObject.UserClickRegisterBrn();
        }

        [Then(@"User search for a product")]
        public void ThenUserSearchForAProduct()
        {
            _searchObject.productSearchWithAutoComplete(Constants.ProductPartName);
        }

        [When(@"User add review")]
        public void WhenUserAddReview()
        {
            _detailsObject.UserAddReview();
            _reviewObject.userSendReview(Constants.Tittle, Constants.ReviewBody);
        }

        [Then(@"success Meg appears")]
        public void ThenSuccessMegAppears()
        {
            Assert.IsTrue(_commonObject.ResultMsg.Text.Contains("Product review is successfully added."));

        }
    }
}
