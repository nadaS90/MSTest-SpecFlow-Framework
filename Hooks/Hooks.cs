using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario("@regression")]
        public void BeforeScenarioWithTag()
        {
          //  SeleniumDrivers seleniumDrivers = new SeleniumDrivers(_scenarioContext);
           // _scenarioContext.Set((seleniumDrivers, "SeleniumDriver"));

            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("selenium WebDriver quit");
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}