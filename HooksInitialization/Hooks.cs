using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBasics.HooksInitialization
{
    [Binding]
    public sealed class Hooks
    {
        private IObjectContainer container;
        public static IWebDriver driver;

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario(@"smoke")]
        public void BeforeScenarioWithTag()
        {
            //  SeleniumDrivers seleniumDrivers = new SeleniumDrivers(_scenarioContext);
            // _scenarioContext.Set((seleniumDrivers, "SeleniumDriver"));

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
           // driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            container.RegisterInstanceAs(driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("selenium WebDriver quit"); 
            driver.Quit();
        }
    }
}