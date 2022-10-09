using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using TechTalk.SpecFlow;
using static SpecFlowBasics.HooksInitialization.Hooks;
using Constants = SpecFlowBasics.data.Constants;



namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class S02_LoginStepDef
    {
        P03_HomePage _homeObject;
        P02_LoginPage _loginObject;
        CommonLocators _commonObject;


        public S02_LoginStepDef(IWebDriver driver)
        {
            this._homeObject = new P03_HomePage(Hooks.driver);
            this._loginObject = new P02_LoginPage(Hooks.driver);
            this._commonObject = new CommonLocators(Hooks.driver);
        }


      /*  [Given(@"user go to login page")]
        public void GivenUserGoToLoginPage()
        {
        } */

        [Given(@"user login with valid email and password")]
        public void GivenUserLoginWithValidEmailAndPassword()
        {
            _commonObject.ClickLoginPage();
            _loginObject.UserEnterEmailAndPassword(Constants.Email, Constants.Password);
            _loginObject.UserLogIn();

        }


        [Then(@"user login to the system successfully")]
        public void ThenUserLoginToTheSystemSuccessfully()
        {
            Assert.IsTrue(_commonObject.LogOutLink.Displayed);

        }

        [When(@"user logout the system")]
        public void WhenUserLogoutTheSystem()
        {
            _commonObject.UserLogOut();

        }

        [When(@"user login with invalid email and password ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserLoginWithInvalidEmailAndPasswordAnd(string Email, string Password)
        {
            _commonObject.ClickLoginPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _loginObject.UserEnterEmailAndPassword(Email, Password);
        }

        [Then(@"user could not login to the system")]
        public void ThenUserCouldNotLoginToTheSystem()
        {
            _loginObject.UserLogIn();
            // Assert error meg
            Assert.IsTrue(_loginObject.ErrorMsg.Text.Contains("Login was unsuccessful. Please correct the errors and try again."));

        }
    }
}
