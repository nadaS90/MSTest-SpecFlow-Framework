using System.Drawing;
using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Pages;

public class WishListPage : PageBase
{
    public WishListPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String ItemsListWishID = "td.product";
    public const String RemoveItemsBtnID = "button.remove-btn";
    public const String EmptyCartLblID = "div.no-data";
   // public const String WishListProductsNoID = "div.wishlist-content";

    #endregion

    public IWebElement ItemsListWish => driver.FindElement(By.CssSelector(ItemsListWishID));
    public IWebElement RemoveItemsBtn => driver.FindElement(By.CssSelector(RemoveItemsBtnID));
    public IWebElement EmptyCartLbl => driver.FindElement(By.CssSelector(EmptyCartLblID));
    //public IWebElement WishListProductsNo => driver.FindElement(By.CssSelector(WishListProductsNoID));



    public void RemoveProductFromWishlist()
    {
        ClickBtn(RemoveItemsBtn);
    }
}

