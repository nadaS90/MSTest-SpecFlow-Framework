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
        CommonLocators _commonObject;
        ProductDetailsPage _detailsObject;
        AddReviewPage _reviewObject;



        public AddReviewStepDef(IWebDriver driver)
        {
            this._commonObject = new CommonLocators(Hooks.driver);
            this._detailsObject = new ProductDetailsPage(Hooks.driver);
            this._reviewObject = new AddReviewPage(Hooks.driver);


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
