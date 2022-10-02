using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFrameworkCSharp.pages;
using SeleniumFrameworkCSharp.data;
using SeleniumFrameworkCSharp.tests;

namespace SeleniumLearning.tests;
[TestClass]

public class ChangeCurrencyStepDef : TestBase
{
    HomePage HomeObject;
    SearchProductPage SearchObject;
    ProductDetailsPage ProductObject;

    public ChangeCurrencyStepDef()
    {
        HomeObject = new HomePage(driver);
        SearchObject = new SearchProductPage(driver);
        ProductObject = new ProductDetailsPage(driver);
    }


    [TestMethod]
    public void UserChangeCurrency()
    {
        HomeObject.ClickChangeCurrency();

        try
        {
            SearchObject.productSearchWithAutoComplete("MacB");
            Assert.IsTrue(ProductObject.ProductName.Text.Contains(Constants.producrName));
            Assert.IsTrue(ProductObject.CurrencyType.Text.Contains("€"));
            Console.WriteLine(ProductObject.CurrencyType.Text);
        }

        catch (Exception e)
        {
            Console.WriteLine("We have an error" + e.Message);
        }
    }



}