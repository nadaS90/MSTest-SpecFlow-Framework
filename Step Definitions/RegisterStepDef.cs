using OpenQA.Selenium;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using SpecFlowBasics.Common_Locators;
using TechTalk.SpecFlow;
using Constants = SpecFlowBasics.data.Constants;
using static SpecFlowBasics.HooksInitialization.Hooks;



namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class RegisterStepDef
    {
        HomePage _homeObject;
        RegisterPage _registerObject;
        CommonLocators _commonObject;

        static string RegisteredEmail = "";

        public RegisterStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
            this._registerObject = new RegisterPage(Hooks.driver);
            this._commonObject = new CommonLocators(Hooks.driver);

        }

        [Given(@"user navigates to register page")]
        public void GivenUserNavigatesToRegisterPage()
        {
            _commonObject.ClickRegisterLink();
        }

        [Given(@"user select gender")]
        public void GivenUserSelectGender()
        {
            _registerObject.UserSelectGender();
        }

        [When(@"enter first name and last name")]
        public void WhenEnterFirstNameAndLastName()
        {
            _registerObject.UserAddFandLname(Constants.FName, Constants.LName);
        }

        [When(@"user enter email")]
        public void WhenUserEnterEmail()
        {
            RegisteredEmail = Constants.Email;
         //   _homeObject.RegisteredEmail = RegisteredEmail;
            _registerObject.UserAddEmail(RegisteredEmail);
        }

        [When(@"user fills Password fields")]
        public void WhenUserFillsPasswordFields()
        {
            _registerObject.UserAddPassword(Constants.Password);
        }

        [Then(@"user could register successfully")]
        public void ThenUserCouldRegisterSuccessfully()
        {
            _registerObject.UserClickRegisterBrn();
            Assert.IsTrue(_registerObject.SuccessfulMsg.Text.Contains("Your registration completed"));
        }

    }
}
