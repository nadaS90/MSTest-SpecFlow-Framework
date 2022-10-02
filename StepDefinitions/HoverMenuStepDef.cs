using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFrameworkCSharp.pages;
using SeleniumFrameworkCSharp.tests;

namespace SeleniumLearning.tests;

[TestClass]

public class HoverMenuStepDef : TestBase
{
    HomePage HomeObject;
    ProductDetailsPage ProductObject;

    public HoverMenuStepDef()
    {
        HomeObject = new HomePage(driver);
        ProductObject = new ProductDetailsPage(driver);
    }

    [TestMethod]
    public void UserHoverAndSelect()
    {
        HomeObject.HoverMenuAndSelectCategory();
        Assert.IsTrue(HomeObject.HoverMenu.Text.Contains("Electronics"));
        Console.WriteLine(HomeObject.HoverMenu.Text);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        Console.WriteLine(HomeObject.HoverDropDown.Text);

        Assert.IsTrue(ProductObject.PageTittle.Text.Contains("Cell phones"));
        Console.WriteLine(ProductObject.PageTittle.Text);


    }




}

