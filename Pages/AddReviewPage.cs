using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Pages;

public class AddReviewPage : PageBase
{
    public AddReviewPage(IWebDriver driver) : base(driver)
    {
    }


    #region MyRegion
    //Locators :
    public const String TittleTxtBoxID = "AddProductReview_Title";
    public const String ReviewTxtBoxID = "AddProductReview_ReviewText";
    public const String RateBtnID = "addproductrating_2";
    public const String SubmitBtnID = "div.buttons";

    #endregion

    public IWebElement TittleTxtBox => driver.FindElement(By.Id(TittleTxtBoxID));
    public IWebElement ReviewTxtBox => driver.FindElement(By.Id(ReviewTxtBoxID));
    public IWebElement RateBtn => driver.FindElement(By.Id(RateBtnID));
    public IWebElement SubmitBtn => driver.FindElement(By.CssSelector(SubmitBtnID));


    public void userSendReview(String tittle, String reviewBody)
    {
        SendTxt(TittleTxtBox, tittle);
        SendTxt(ReviewTxtBox, reviewBody);
        ClickBtn(RateBtn);
        ClickBtn(SubmitBtn);
    }

}