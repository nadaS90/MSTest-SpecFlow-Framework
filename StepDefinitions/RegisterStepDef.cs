using OpenQA.Selenium;
using System;
using SpecFlowBasics.Helpers;
using SpecFlowBasics.Hooks;
using TechTalk.SpecFlow;
using SeleniumFrameworkCSharp.pages;

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
          //  Assert.IsTrue(HomeObject.driver.getCurrentUrl().contains("register"));
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
            IWebElement EmailTextBox = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.EmailID));
            PageBase.SendTxt(EmailTextBox, Email);

            throw new PendingStepException();
        }

        [When(@"user fills Password fields")]
        public void WhenUserFillsPasswordFields(String Password)
        {
            IWebElement PasswordTextField = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.PasswordID));
            IWebElement ConfirmPasswordTextBox = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.ConfirmPasswordID));
            PageBase.SendTxt(PasswordTextField, Password);
            PageBase.SendTxt(ConfirmPasswordTextBox, Password);

            throw new PendingStepException();
        }

        [Then(@"user could register successfully")]
        public void ThenUserCouldRegisterSuccessfully()
        {
            IWebElement RegisterBtn = SeleniumDrivers.driver.FindElement(By.Id(RegisterPage.RegisterBtnID));
            PageBase.ClickBtn(RegisterBtn);
            IWebElement SuccessfulMsg = SeleniumDrivers.driver.FindElement(By.CssSelector(RegisterPage.SuccessMsgID));

            //throw new PendingStepException();
        }

    }
}




