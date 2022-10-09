using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using SpecFlowBasics.data;
using TechTalk.SpecFlow;

namespace SpecFlowBasics
{
    [Binding]
    public class S10_EmailAFreindStepDef
    {
        CommonLocators _commonObject;
        P05_ProductDetailsPage _detailsObject;
        P09_EmailAFreindPage _emailObject;

        public S10_EmailAFreindStepDef(IWebDriver driver)
        {
            this._commonObject = new CommonLocators(Hooks.driver);
            this._detailsObject = new P05_ProductDetailsPage(Hooks.driver);
            this._emailObject = new P09_EmailAFreindPage(Hooks.driver);
        }

        [When(@"User Add a friend e-mail and send")]
        public void WhenUserAddAFriendE_MailAndSend()
        {
            _detailsObject.EmailProductToAFriend();
            _emailObject.UserEmailFriend(Constants.Friend, Constants.MsgBody);
        }

        [Then(@"successful Msg appears")]
        public void ThenSuccessfulMsgAppears()
        {
            Assert.IsTrue(_commonObject.ResultMsg.Text.Contains("Your message has been sent."));
        }
    }
}
