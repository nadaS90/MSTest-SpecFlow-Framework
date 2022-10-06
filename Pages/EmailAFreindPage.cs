using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SpecFlowBasics.Pages;

public class EmailAFreindPage : PageBase
    {
    public EmailAFreindPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String FiendEmailTxtBoxID = "FriendEmail";
    public const String MyEmailTxtBoxID = "YourEmailAddress";
    public const String MessageTxtBoxID = "PersonalMessage";
    public const String SubmitBtnID = "div.buttons";
    #endregion

    public IWebElement FiendEmailTxtBox => driver.FindElement(By.Id(FiendEmailTxtBoxID));
    public IWebElement MyEmailTxtBox => driver.FindElement(By.Id(MyEmailTxtBoxID));
    public IWebElement MessageTxtBox => driver.FindElement(By.Id(MessageTxtBoxID));
    public IWebElement SubmitBtn => driver.FindElement(By.CssSelector(SubmitBtnID));

    public void UserEmailFriend(String friend, String msgBody)
    {
        SendTxt(FiendEmailTxtBox, friend);
        SendTxt(MessageTxtBox, msgBody);
        ClickBtn(SubmitBtn);

    }



}