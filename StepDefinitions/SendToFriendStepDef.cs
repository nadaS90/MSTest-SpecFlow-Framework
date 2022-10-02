using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFrameworkCSharp.data;
using SeleniumFrameworkCSharp.pages;
using SeleniumFrameworkCSharp.tests;

namespace SeleniumLearning.tests;
[TestClass]

public class AddProductToCartTest : TestBase
{
    SearchProductPage SearchObject;
    ProductDetailsPage ProductObject;
    AddProductToCartPage AddProductToCarObject;


    public AddProductToCartTest()
    {
        SearchObject = new SearchProductPage(driver);
        ProductObject = new ProductDetailsPage(driver);
        AddProductToCarObject = new AddProductToCartPage(driver);
    }

    [TestMethod]
    public void User1SearchProductWithAutoComplete()
    {
        try
        {
            SearchObject.productSearchWithAutoComplete("Asus");
            Assert.IsTrue(ProductObject.ProductName.Text.Contains(Constants.producrName));
        }
        catch (Exception e)
        {
            Console.WriteLine("We have an error " + e.Message);
        }

        ProductObject.UserAddProductToCart();
        Assert.IsTrue(ProductObject.PopSucessMsg.Text.Contains("The product has been added to your "));
       // Console.WriteLine(ProductObject.PopSucessMsg.Text);
        ProductObject.ClosePopUpMsg();

        driver.Navigate().GoToUrl("http://demo.nopcommerce.com" + "/cart");
        Assert.IsTrue(AddProductToCarObject.Product.Text.Contains("N551JK-XO076H"));
        Assert.IsTrue(AddProductToCarObject.TotalAmount.Text.Contains("$1,500.00"));

        AddProductToCarObject.RemoveProductFromCart();
        Assert.IsTrue(AddProductToCarObject.EmptyMsg.Text.Contains("Your Shopping Cart is empty!"));
    }


  /*  [TestMethod]
    public void User2AddProductToCart()
    {
       
    }

    [TestMethod]
    public void User3CheckCartItemsAndRemove()
    {
       
       
    }*/









}