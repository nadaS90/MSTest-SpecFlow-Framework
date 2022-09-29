using OpenQA.Selenium;
using SpecFlowBasics.Helpers;

namespace SeleniumFrameworkCSharp.pages;

public class LoginPage : PageBase
{
    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String EmailID = "Email";
    public const String PasswordID = "Password";
    public const String LoginBtnID = "button.login-button";
    #endregion

    IWebElement EmailTextBox => driver.FindElement(By.Id(EmailID));
    IWebElement PasswordTextField => driver.FindElement(By.Id(PasswordID));
    IWebElement LoginBtn => driver.FindElement(By.CssSelector(LoginBtnID));


    public void UserLogIn(String Email, String Password)
    {
        SendTxt(EmailTextBox, Email);
        SendTxt(PasswordTextField, Password);
        ClickBtn(LoginBtn);
    }

}