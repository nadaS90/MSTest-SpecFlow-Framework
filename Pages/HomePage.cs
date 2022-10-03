using System.Transactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowBasics.Helpers;
using SpecFlowBasics.HooksInitialization;

namespace SpecFlowBasics.Pages; 
public class HomePage : PageBase
{
    //private static IWebDriver driver;
    public HomePage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string RegisterLinkID = "Register";
    public const String LoginLinkID = "Log in";
    public const String ChangeCurancyID = "customerCurrency";
    public const String HoverMenuID = "ul[class=\"top-menu notmobile\"] [href=\"/electronics\"]";
    public const String HoverDropDownID = "//a[@href=\"/cell-phones\"]";
    public const String FaceBookLinkID = "//a[@href=\"http://www.facebook.com/nopCommerce\"]";
    public const string TwitterLinkID = "//a[@href=\"https://twitter.com/nopCommerce\"]";
    public const String YouTubeLinkID = "//a[@href=\"http://www.youtube.com/user/nopCommerce\"]";
    public const String LogOutID = "Log out";
    public const String CurrencyID = "div.prices";

    #endregion

    IWebElement RegisterLink => driver.FindElement(By.LinkText(RegisterLinkID));
    IWebElement LoginLink => driver.FindElement(By.LinkText(LoginLinkID));
    IWebElement ChangeCurrency => driver.FindElement(By.Id(ChangeCurancyID));
    public IWebElement HoverMenu => driver.FindElement(By.CssSelector(HoverMenuID));
    public IWebElement HoverDropDown => driver.FindElement(By.XPath(HoverDropDownID));
    IWebElement FaceBook => driver.FindElement(By.XPath(FaceBookLinkID)); 
    IWebElement Twitter => driver.FindElement(By.XPath(TwitterLinkID)); 
    IWebElement YouTube => driver.FindElement(By.XPath(YouTubeLinkID));
    public IWebElement LogOutLink => driver.FindElement(By.LinkText(LogOutID));
    public IList<IWebElement> Currency => driver.FindElements(By.CssSelector(CurrencyID));







    public void ClickRegisterLink()
     {
         ClickBtn(RegisterLink);
     }

     public void ClickLoginPage()
     {
         ClickBtn(LoginLink);
     }

     public void ClickChangeCurrency()
     {
         Select = new SelectElement(ChangeCurrency);
     }

     public void UserChooserEuro()
     {
         Select.SelectByText("Euro");
     }

    public void HoverMenuAndSelectCategory()
     {
         Actions action = new Actions(Hooks.driver);
         action.MoveToElement(HoverMenu).Perform();
         action.MoveToElement(HoverDropDown).Click().Perform();
         Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

    }

     public void UserNavigateToFaceBook()
     {
         ClickBtn(FaceBook);
     }

     public void UserNavigateToTwitter()
     {
         ClickBtn(Twitter);
     }
     public void UserNavigateToYouTube()
     {
         ClickBtn(YouTube);
     }
     public void UserLogOut()
     {
         ClickBtn(LogOutLink);
     }
}