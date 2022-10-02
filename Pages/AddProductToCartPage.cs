using OpenQA.Selenium;


public class AddProductToCartPage 
{
    public AddProductToCartPage(IWebDriver driver) 
    {
    }


    #region MyRegion
    //Locators :
    public const String ProductID = "Asus N551JK-XO076H Laptop";
    public const String TotalAmountID = "div.total-info";
    public const String RemoveBtnID = "button.remove-btn";
    public const String EmptyMsgID = "div.no-data";
    #endregion

 /*   public IWebElement Product => driver.FindElement(By.LinkText(ProductID));
    public IWebElement TotalAmount => driver.FindElement(By.CssSelector(TotalAmountID)); 
    IWebElement RemoveBtn => driver.FindElement(By.CssSelector(RemoveBtnID));
    public IWebElement EmptyMsg => driver.FindElement(By.CssSelector(EmptyMsgID));
    public void RemoveProductFromCart()
    {
        ClickBtn(RemoveBtn);
    }
 */
}
