using OpenQA.Selenium;
using SpecFlowBasics.Helpers;
namespace SpecFlowBasics.Pages;

public class P01_RegisterPage : PageBase

{
    public P01_RegisterPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const string GenderFemaleID = "gender-female";
    public const String FirstNameID = "FirstName";
    public const String LastNameID = "LastName";
    public const String EmailID = "Email";
    public const String PasswordID = "Password";
    public const String ConfirmPasswordID = "ConfirmPassword";
    public const String RegisterBtnID = "register-button";
    public const String SuccessMsgID = "div.result";
    public const String LogOutID = "Log out";
    public const String MyAccountID = "My account";
    #endregion


    public IWebElement GenderRdBtn => driver.FindElement(By.Id(GenderFemaleID));
    public IWebElement FirstNameTxtBox => driver.FindElement(By.Id(FirstNameID));
    public IWebElement LastNameTextBox => driver.FindElement(By.Id(LastNameID));
    public IWebElement EmailTextBox => driver.FindElement(By.Id(EmailID));
    public IWebElement PasswordTextField => driver.FindElement(By.Id(PasswordID));
    public IWebElement ConfirmPasswordTextBox => driver.FindElement(By.Id(ConfirmPasswordID));
    public IWebElement RegisterBtn => driver.FindElement(By.Id(RegisterBtnID));
    public IWebElement SuccessfulMsg => driver.FindElement(By.CssSelector(SuccessMsgID));
    public IWebElement LogOutLink => driver.FindElement(By.LinkText(LogOutID));
    IWebElement MyAccountLink => driver.FindElement(By.LinkText(MyAccountID));


    public void UserSelectGender()
    {
        ClickBtn(GenderRdBtn);
    }
    public void UserAddFandLname(String FName, String LName)
    {
        SendTxt(FirstNameTxtBox, FName);
        SendTxt(LastNameTextBox, LName);
    }
    public void UserAddPassword(String Password)
    {
        SendTxt(PasswordTextField, Password);
        SendTxt(ConfirmPasswordTextBox, Password);
    }
    public void UserAddEmail(String Email)
    {
        SendTxt(EmailTextBox, Email);
    }
    public void UserClickRegisterBrn()
    {
        ClickBtn(RegisterBtn);
    }

    public void UserLogOut()
    {
        ClickBtn(LogOutLink);
    }

    public void UserOpenMyAccountPage()
    {
        ClickBtn(MyAccountLink);
    }
}