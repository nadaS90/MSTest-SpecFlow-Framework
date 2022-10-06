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
    public class EmailAFreindStepDef
    {
        CommonLocators _commonObject;
        ProductDetailsPage _detailsObject;
        EmailAFreindPage _emailObject;

        public EmailAFreindStepDef(IWebDriver driver)
        {
            this._commonObject = new CommonLocators(Hooks.driver);
            this._detailsObject = new ProductDetailsPage(Hooks.driver);
            this._emailObject = new EmailAFreindPage(Hooks.driver);
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
