using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class LoginStepDef
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"user go to login page")]
        public void GivenUserGoToLoginPage()
        {
            throw new PendingStepException();
        }

        [Given(@"user login with valid email and password ""([^""]*)"" and ""([^""]*)""")]
        public void GivenUserLoginWithValidEmailAndPasswordAnd(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"user login to the system successfully")]
        public void ThenUserLoginToTheSystemSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"user logout the system")]
        public void WhenUserLogoutTheSystem()
        {
            throw new PendingStepException();
        }

        [When(@"user login with invalid email and password ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserLoginWithInvalidEmailAndPasswordAnd(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"user could not login to the system")]
        public void ThenUserCouldNotLoginToTheSystem()
        {
            throw new PendingStepException();
        }
    }
}
