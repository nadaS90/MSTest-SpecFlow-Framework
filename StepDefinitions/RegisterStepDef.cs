using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class RegisterStepDef
    {
        private readonly ScenarioContext _scenarioContext;

        public RegisterStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"user navigates to register page")]
        public void GivenUserNavigatesToRegisterPage()
        {
            throw new PendingStepException();
        }

        [Given(@"user select gender")]
        public void GivenUserSelectGender()
        {
            throw new PendingStepException();
        }

        [When(@"enter first name and last name")]
        public void WhenEnterFirstNameAndLastName()
        {
            throw new PendingStepException();
        }


        [When(@"user enter email ""([^""]*)""")]
        public void WhenUserEnterEmail()
        {
            throw new PendingStepException();
        }

        [When(@"user fills Password fields ""([^""]*)""")]
        public void WhenUserFillsPasswordFields()
        {
            throw new PendingStepException();
        }

        [Then(@"user could register successfully")]
        public void ThenUserCouldRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
