using OpenQA.Selenium;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using TechTalk.SpecFlow;
using static SpecFlowBasics.HooksInitialization.Hooks;
using Constants = SpecFlowBasics.data.Constants;



namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class LoginStepDef
    {
        HomePage _homeObject;
        LoginPage _loginObject;

        public LoginStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
        }


        [Given(@"user go to login page")]
        public void GivenUserGoToLoginPage()
        {
            _homeObject.ClickLoginPage();
        }

        [Given(@"user login with valid email and password")]
        public void GivenUserLoginWithValidEmailAndPassword()
        {
            _loginObject.UserEnterEmailAndPassword(Constants.Email, Constants.Password);
        }


        [Then(@"user login to the system successfully")]
        public void ThenUserLoginToTheSystemSuccessfully()
        {
            _loginObject.UserLogIn();
        }

        [When(@"user logout the system")]
        public void WhenUserLogoutTheSystem()
        {
            _homeObject.UserLogOut();
        }

        [When(@"user login with invalid email and password ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserLoginWithInvalidEmailAndPasswordAnd(string Email, string Password)
        {
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
