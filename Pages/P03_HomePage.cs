using System.Transactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.Helpers;
using SpecFlowBasics.HooksInitialization;

namespace SpecFlowBasics.Pages; 
public class P03_HomePage : PageBase
{
    //private static IWebDriver driver;
    public String RegisteredEmail { get; set; }

    public P03_HomePage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String HoverMenuID = "ul[class=\"top-menu notmobile\"] [href=\"/electronics\"]";
    public const String HoverDropDownID = "//a[@href=\"/cell-phones\"]";
    public const String FaceBookLinkID = "//a[@href=\"http://www.facebook.com/nopCommerce\"]";
    public const string TwitterLinkID = "//a[@href=\"https://twitter.com/nopCommerce\"]";
    public const String YouTubeLinkID = "//a[@href=\"http://www.youtube.com/user/nopCommerce\"]";
    public const String WishListProductID = "a[href=\"/htc-one-m8-android-l-50-lollipop\"]";

    #endregion

   
    public IWebElement HoverMenu => driver.FindElement(By.CssSelector(HoverMenuID));
    public IWebElement HoverDropDown => driver.FindElement(By.XPath(HoverDropDownID));
    IWebElement FaceBook => driver.FindElement(By.XPath(FaceBookLinkID)); 
    IWebElement Twitter => driver.FindElement(By.XPath(TwitterLinkID)); 
    IWebElement YouTube => driver.FindElement(By.XPath(YouTubeLinkID));
    public IWebElement WishListProduct => driver.FindElement(By.CssSelector(WishListProductID)); 
  




    

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

     public void SelectProductToWishList()
     {
        ClickBtn(WishListProduct); 
     }
}