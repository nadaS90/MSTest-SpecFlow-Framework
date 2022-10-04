using OpenQA.Selenium;
using SpecFlowBasics.Helpers;


public class ProductDetailsPage : PageBase
{
    public ProductDetailsPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string ProductNameID = "div.product-name";
    public const string EmailtoFriendID = "div.email-a-friend";
    public const string CurrencyTypeID = "price-value-4";
    public const string AddMyReviewID = "Add your review";
   // public const string AddProductWishListID = "add-to-wishlist-button-4";
  //  public const string PopSucessMsgID = "p.content";
   // public const string CloseMsgID = "span.close";
   // public const string CompareProductsID = "div.compare-products";
   // public const string AddToCartID = "add-to-cart-button-5";
    public const String PageTittleID = "div.page-title";
    #endregion

   public IWebElement ProductName => driver.FindElement(By.CssSelector(ProductNameID));
  
    IWebElement EmailtoFriendBtn => driver.FindElement(By.CssSelector(EmailtoFriendID));

    public  IWebElement CurrencyType => driver.FindElement(By.Id(CurrencyTypeID));

    public IWebElement AddMyReviewBtn => driver.FindElement(By.LinkText(AddMyReviewID));

  /* public IWebElement AddProductWishListBtn => driver.FindElement(By.Id(AddProductWishListID));

    public IWebElement PopSucessMsg => driver.FindElement(By.CssSelector(PopSucessMsgID));

    public IWebElement CloseMsgBtn => driver.FindElement(By.CssSelector(CloseMsgID));

    IWebElement CompareProductsBtn => driver.FindElement(By.CssSelector(CompareProductsID));

    IWebElement AddToCartBtn => driver.FindElement(By.Id(AddToCartID));
  */
   public IWebElement PageTittle => driver.FindElement(By.CssSelector(PageTittleID));

    


   public void EmailProductToAFriend()
    {
        ClickBtn(EmailtoFriendBtn);
    }

     public void UserAddReview()
     {
         ClickBtn(AddMyReviewBtn);
     }

 /*    public void UsedAddProductWishList()
      {
          ClickBtn(AddProductWishListBtn);
      } 
 
    public void ClosePopUpMsg()
    {
        ClickBtn(CloseMsgBtn);
    }
    public void UserAddProductToCompare()
      {
          ClickBtn(CompareProductsBtn);
      }

    public void UserAddProductToCart()
    {
        ClickBtn(AddToCartBtn);
    }
 */

}