using System.Drawing;
using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Common_Locators;

public class CommonLocators : PageBase
{
    public CommonLocators(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string AddProductWishListID = "add-to-wishlist-button-4";
    public const string PopSucessMsgID = "p.content";
    public const string CloseMsgID = "span.close";
    public const string CompareProductsID = "div.compare-products";
    public const string AddToCartID = "add-to-cart-button-5";
    public const String WishLisBtnID = "add-to-wishlist-button-18";
    public const String WishListLinkID = "a[href=\"/wishlist\"]";

    #endregion


    public IWebElement AddProductWishListBtn => driver.FindElement(By.Id(AddProductWishListID));
    public IWebElement PopSucessMsg => driver.FindElement(By.CssSelector(PopSucessMsgID));
    public IWebElement CloseMsgBtn => driver.FindElement(By.CssSelector(CloseMsgID));
    IWebElement CompareProductsBtn => driver.FindElement(By.CssSelector(CompareProductsID));
    IWebElement AddToCartBtn => driver.FindElement(By.Id(AddToCartID));
    IWebElement WishListLink => driver.FindElement(By.CssSelector(WishListLinkID));
    IWebElement WishListBtn => driver.FindElement(By.Id(WishLisBtnID));



    public void UsedAddProductWishList()
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

    public void UserNavigateToWishListPage()
    {
        ClickBtn(WishListLink);
    }

    public void ClickWishListBtn()
    {
        ClickBtn(WishListBtn);
    }



}