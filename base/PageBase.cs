using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowBasics.Helpers;

public class PageBase


{
    public  IWebDriver driver;

    public SelectElement Select;
    //  public IJavaScriptExecutor jse;

    // Must create Constractor
    public PageBase(IWebDriver driver)
    {
        this.driver = driver;
    }

  public static void ClickBtn(IWebElement button)
    {
        button.Click();
    }

    public static void SendTxt(IWebElement textElm, string value)
    {
        textElm.SendKeys(value);
    }


    public void ScrollPageToBottom()
    {
        //jse.ExecuteScript(ScrollPageToBottom(0, 2500));
    }

   

}