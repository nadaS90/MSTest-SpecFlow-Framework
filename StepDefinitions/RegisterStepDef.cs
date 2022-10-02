using OpenQA.Selenium;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using Microsoft.VisualBasic;
using TechTalk.SpecFlow;
using SpecFlowBasics.data;
using static SpecFlowBasics.HooksInitialization.Hooks;
using Constants = SpecFlowBasics.data.Constants;


namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class RegisterStepDef
    {
        HomePage _homeObject;
        RegisterPage _registerObject;
        LoginPage _loginObject;
        static string RegisteredEmail = "";

        public RegisterStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
            this._registerObject = new RegisterPage(Hooks.driver);
            this._loginObject = new LoginPage(Hooks.driver);
        }

      //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);


        [Given(@"user directed to register page")]
        public void GivenUserDirectedToRegisterPage()
        {
            _homeObject.ClickRegisterLink();
        }

        [Given(@"user select the gender")]
        public void GivenUserSelectTheGender()
        {
            _registerObject.UserSelectGender();
        }

        [When(@"user enter first name and last name")]
        public void WhenUserEnterFirstNameAndLastName()
        {
            _registerObject.UserAddFandLname(Constants.FName, Constants.LName);
        }

        [When(@"user enter valid email")]
        public void WhenUserEnterValidEmail()
        {
            RegisteredEmail = Constants.Email;
            _registerObject.UserAddEmail(RegisteredEmail);
        }

        [When(@"user fills required Password fields")]
        public void WhenUserFillsRequiredPasswordFields()
        {
            _registerObject.UserAddPassword(Constants.Password);
        }

        [Then(@"user register successfully")]
        public void ThenUserRegisterSuccessfully()
        {
            _registerObject.UserClickRegisterBrn();
            Assert.IsTrue(_registerObject.SuccessfulMsg.Text.Contains("Your registration completed"));
        }

    }
}
