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

    public class S09_AddReviewStepDef
    {
        CommonLocators _commonObject;
        P05_ProductDetailsPage _detailsObject;
        P08_AddReviewPage _reviewObject;



        public S09_AddReviewStepDef(IWebDriver driver)
        {
            this._commonObject = new CommonLocators(Hooks.driver);
            this._detailsObject = new P05_ProductDetailsPage(Hooks.driver);
            this._reviewObject = new P08_AddReviewPage(Hooks.driver);


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
