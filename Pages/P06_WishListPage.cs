using System.Drawing;
using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Pages;

public class P06_WishListPage : PageBase
{
    public P06_WishListPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String ItemsListWishID = "td.product";
    public const String RemoveItemsBtnID = "button.remove-btn";
    public const String EmptyCartLblID = "div.no-data";
   public const String WishListItemsID = "div.wishlist-content";

    #endregion

    public IWebElement ItemsListWish => driver.FindElement(By.CssSelector(ItemsListWishID));
    public IWebElement RemoveItemsBtn => driver.FindElement(By.CssSelector(RemoveItemsBtnID));
    public IWebElement EmptyCartLbl => driver.FindElement(By.CssSelector(EmptyCartLblID));
    public IList<IWebElement> WishListItems => driver.FindElements(By.CssSelector(WishListItemsID));



    public void RemoveProductFromWishlist()
    {
        ClickBtn(RemoveItemsBtn);
    }

    public int GetItemsNoInWishList()
    {
        int ItemsNo = WishListItems.Count;
        return ItemsNo;
    }
}

