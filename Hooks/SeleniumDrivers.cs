using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.Hooks;

public class SeleniumDrivers
{
    public static IWebDriver driver;
    private readonly ScenarioContext _scenarioContext;

    public SeleniumDrivers(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    // create webdriver initialization
    public IWebDriver SetUp()
    {
        var firefoxOptions = new FirefoxOptions();
        var ideOptions = new EdgeOptions();

        _scenarioContext.Set(driver, "WebDriver");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
        driver.Manage().Window.Maximize();

        return driver;
    }

    public dynamic SelectBrowser(string browserName)
    {
        if (browserName.ToLower() == "chrome")
            return new ChromeOptions();
        if (browserName.ToLower() == "firefox")
            return new FirefoxOptions();
        if (browserName.ToLower() == "IDE")
            return new EdgeOptions();
        return new ChromeOptions();

    }




}