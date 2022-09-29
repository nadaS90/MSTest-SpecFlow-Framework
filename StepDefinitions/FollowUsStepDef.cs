using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static SpecFlowBasics.HooksInitialization.Hooks;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class FollowUsStepDef
    {
        HomePage _homeObject; 
        //Hooks HooksObject;


        public FollowUsStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
           // this.HooksObject = new Hooks();
        }

        [Given(@"user clicks on facebook")]
        public void GivenUserClicksOnFacebook()
        {
            _homeObject.UserNavigateToFaceBook();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //get current window handle id
            Console.WriteLine(driver.Url);
            Console.WriteLine("Current window id: " + driver.CurrentWindowHandle);
            Console.WriteLine("Page title in second tab is: " + driver.Title);
        }

         [Then(@"user navigates to facebook ""([^""]*)""")]
         public void ThenUserNavigatesToFacebook(String url)
        {
            Console.WriteLine(Hooks.driver.Url);
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            // close second Tab
            Hooks.driver.Close();
            Hooks.driver.SwitchTo().Window(Hooks.driver.WindowHandles[0]);
        }


        [Given(@"user clicks on twitter")]
        public void GivenUserClicksOnTwitter()
        {
            _homeObject.UserNavigateToTwitter();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //get current window handle id
            Console.WriteLine(driver.Url);
            Console.WriteLine("Current window id: " + driver.CurrentWindowHandle);
            Console.WriteLine("Page title in second tab is: " + driver.Title);
        }

        [Then(@"user navigates to twitter ""([^""]*)""")]
        public void ThenUserNavigatesToTwitter(String url)
        {
            Console.WriteLine(Hooks.driver.Url);
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            // close second Tab
            Hooks.driver.Close();
            Hooks.driver.SwitchTo().Window(Hooks.driver.WindowHandles[0]);
        }

        [Given(@"user clicks on youtube")]
        public void GivenUserClicksOnYouTube()
        {
            _homeObject.UserNavigateToYouTube();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //get current window handle id
            Console.WriteLine(driver.Url);
            Console.WriteLine("Current window id: " + driver.CurrentWindowHandle);
            Console.WriteLine("Page title in second tab is: " + driver.Title);
        }

        [Then(@"user navigates to youtube ""([^""]*)""")]
        public void ThenUserNavigatesToYouTube(String url)
        {
            Console.WriteLine(Hooks.driver.Url);
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            // close second Tab
            Hooks.driver.Close();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Hooks.driver.SwitchTo().Window(Hooks.driver.WindowHandles[0]);
        }
    }
}