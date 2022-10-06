using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using SpecFlowBasics.data;
using TechTalk.SpecFlow;

namespace SpecFlowBasics
{
    [Binding]
    public class AddProductToCartStepDef
    {
        
        CommonLocators _commonObject;
        SearchProductPage _searchObject;
        ProductDetailsPage _detailsObject;
        AddProductToCartPage _cartObject;

        public AddProductToCartStepDef(IWebDriver driver)
        {
            this._commonObject = new CommonLocators(Hooks.driver);
            this._searchObject = new SearchProductPage(Hooks.driver);
            this._detailsObject = new ProductDetailsPage(Hooks.driver);
            this._cartObject = new AddProductToCartPage(Hooks.driver);

        }
        [Given(@"User search for a product")]
        public void GivenUserSearchForAProduct()
        {
            _searchObject.productSearchWithAutoComplete(Constants.ProductPartName);
            Assert.IsTrue(_detailsObject.ProductName.Text.Contains(Constants.producrName));
        }

        [When(@"user add product to the cart")]
        public void WhenUserAddProductToTheCart()
        {
            _commonObject.ClickAddCart();
            // Assert.IsTrue(_commonObject.PopSucessMsg.Text.Contains("The product has been added to your "));
            // Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            // _commonObject.ClosePopUpMsg();
            Assert.IsTrue(_commonObject.PopSucessMsg.Text.Contains("The product has been added to your "));

            _commonObject.ClosePopUpMsg();
        }

        [When(@"User navigates to cart and find product")]
        public void WhenUserNavigatesToCartAndFindProduct()
        {
            Hooks.driver.Navigate().GoToUrl("http://demo.nopcommerce.com" + "/cart");
            Assert.IsTrue(_cartObject.Product.Text.Contains("13-inch"));
            Assert.IsTrue(_cartObject.TotalAmount.Text.Contains("$3,600.00"));
        }

        [Then(@"User can remove the product")]
        public void ThenUserCanRemoveTheProduct()
        {
            _cartObject.RemoveProductFromCart();
            Assert.IsTrue(_cartObject.EmptyMsg.Text.Contains("Your Shopping Cart is empty!"));
        }
    }
}
