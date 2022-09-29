using OpenQA.Selenium;
using System;
using Microsoft.VisualBasic;
using SpecFlowBasics.Helpers;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using TechTalk.SpecFlow;


namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class RegisterStepDef
    {
        HomePage HomeObject;
        RegisterPage RegisterObject;
        LoginPage LoginObject;
        static string RegisteredEmail = "";

        private readonly ScenarioContext _scenarioContext;

        public RegisterStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"user navigates to register page")]
        public void GivenUserNavigatesToRegisterPage()
        { 
            HomeObject.ClickRegisterLink();
        }

        [Given(@"user select gender")]
        public void GivenUserSelectGender()
        {
            RegisterObject.GenderRdBtn.Click();
            /*IWebElement GenderRdBtn = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.GenderFemaleID));
            PageBase.ClickBtn(GenderRdBtn);

            throw new PendingStepException();*/
        }

        [When(@"enter first name and last name")]
        public void WhenEnterFirstNameAndLastName(String FName, String LName)
        {

           // RegisterObject.FirstNameTxtBox.SendKeys(FName, LName);
           /* IWebElement FirstNameTxtBox = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.FirstNameID));
            IWebElement LastNameTextBox = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.LastNameID));
            PageBase.SendTxt(FirstNameTxtBox, FName);
            PageBase.SendTxt(LastNameTextBox, LName);
            throw new PendingStepException();*/
        }


        [When(@"user enter email")]
        public void WhenUserEnterEmail(String Email)
        {
           // RegisteredEmail = Constants.;

            IWebElement EmailTextBox = Hooks.driver.FindElement(By.Id(RegisterPage.EmailID));
            PageBase.SendTxt(EmailTextBox, Email);

            throw new PendingStepException();
        }

        [When(@"user fills Password fields")]
        public void WhenUserFillsPasswordFields(String Password)
        {
            IWebElement PasswordTextField = Hooks.driver.FindElement(By.Id(RegisterPage.PasswordID));
            IWebElement ConfirmPasswordTextBox = Hooks.driver.FindElement(By.Id(RegisterPage.ConfirmPasswordID));
            PageBase.SendTxt(PasswordTextField, Password);
            PageBase.SendTxt(ConfirmPasswordTextBox, Password);

            throw new PendingStepException();
        }

        [Then(@"user could register successfully")]
        public void ThenUserCouldRegisterSuccessfully()
        {
            IWebElement RegisterBtn = Hooks.driver.FindElement(By.Id(RegisterPage.RegisterBtnID));
            PageBase.ClickBtn(RegisterBtn);
            IWebElement SuccessfulMsg = Hooks.driver.FindElement(By.CssSelector(RegisterPage.SuccessMsgID));

            //throw new PendingStepException();
        }

    }
}




