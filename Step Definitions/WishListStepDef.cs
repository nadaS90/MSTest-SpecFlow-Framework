using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using System.Drawing;
using TechTalk.SpecFlow;

namespace SpecFlowBasics
{
    [Binding]
    public class WishListStepDef
    {
        HomePage _homeObject;
        CommonLocators _commonObject;
        WishListPage _wishObject;

        public WishListStepDef(IWebDriver driver)
        {
            this._homeObject = new HomePage(Hooks.driver);
            this._commonObject = new CommonLocators(Hooks.driver);
            this._wishObject = new WishListPage(Hooks.driver);

        }

        [Given(@"User clicks on add product wishlist")]
        public void GivenUserClicksOnAddProductWishlist()
        {
            _homeObject.SelectProductToWishList();
            _commonObject.ClickWishListBtn();
        }

        [Then(@"Success message appears")]
        public void ThenSuccessMessageAppears()
        {
            Assert.IsTrue(_commonObject.PopSucessMsg.Text.Contains("The product has been added to your "));

            _commonObject.ClosePopUpMsg();
        }

        [When(@"User navigates to wishlist page")]
        public void WhenUserNavigatesToWishlistPage()
        {
            _commonObject.UserNavigateToWishListPage();
        }


        [Then(@"product found in wishlist page")]
        public void ThenProductFoundInWishlistPage()
        {
            int ItemsNo = _wishObject.GetItemsNoInWishList();
            Console.WriteLine("No. of items in wishlist: " + ItemsNo);
           Assert.IsTrue(ItemsNo > 0, "Items Found");
           Assert.IsTrue(_wishObject.ItemsListWish.Displayed);
           Assert.IsTrue(_wishObject.ItemsListWish.Text.Contains("pop"));    
           Console.WriteLine(_wishObject.ItemsListWish.Text);
        }

        [Then(@"user can delete product")]
        public void ThenUserCanDeleteProduct()
        {
            _wishObject.RemoveProductFromWishlist();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            Assert.IsTrue(_wishObject.EmptyCartLbl.Text.Contains("The wishlist is empty!"));
            Console.WriteLine(_wishObject.EmptyCartLbl.Text);
        }




    }
}
