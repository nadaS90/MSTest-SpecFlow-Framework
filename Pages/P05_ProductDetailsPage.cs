using OpenQA.Selenium;
using SpecFlowBasics.Helpers;


public class P05_ProductDetailsPage : PageBase
{
    public P05_ProductDetailsPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string ProductNameID = "div.product-name";
    public const string EmailtoFriendID = "div.email-a-friend";
    public const string CurrencyTypeID = "price-value-4";
    public const string AddMyReviewID = "Add your review";
    public const String PageTittleID = "div.page-title";
    #endregion

   public IWebElement ProductName => driver.FindElement(By.CssSelector(ProductNameID));
   IWebElement EmailtoFriendBtn => driver.FindElement(By.CssSelector(EmailtoFriendID));
    public  IWebElement CurrencyType => driver.FindElement(By.Id(CurrencyTypeID));
    public IWebElement AddMyReviewBtn => driver.FindElement(By.LinkText(AddMyReviewID));
    public IWebElement PageTittle => driver.FindElement(By.CssSelector(PageTittleID));



    public void EmailProductToAFriend()
    {
        ClickBtn(EmailtoFriendBtn);
    }

     public void UserAddReview()
     {
         ClickBtn(AddMyReviewBtn);
     }



}