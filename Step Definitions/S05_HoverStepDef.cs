using OpenQA.Selenium;
using SpecFlowBasics.Common_Locators;
using SpecFlowBasics.HooksInitialization;
using SpecFlowBasics.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasics
{
    [Binding]
    public class S05_HoverStepDef
    {

        P03_HomePage _homeObject;
        P05_ProductDetailsPage _productObject;



       public S05_HoverStepDef(IWebDriver driver)
        {
            this._homeObject = new P03_HomePage(Hooks.driver);
            this._productObject = new P05_ProductDetailsPage(Hooks.driver);

        }


        [Given(@"user hover categories")]
        public void GivenUserHoverCategories()
        {
            _homeObject.HoverMenuAndSelectCategory();
            Assert.IsTrue(_homeObject.HoverMenu.Text.Contains("Electronics"));
            Console.WriteLine(_homeObject.HoverMenu.Text);
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Given(@"user select sub category")]
        public void GivenUserSelectSubCategory()
        {
            Console.WriteLine(_homeObject.HoverDropDown.Text);
        }

        [Then(@"user directed to the item page")]
        public void ThenUserDirectedToTheItemPage()
        {
            Assert.IsTrue(_productObject.PageTittle.Text.Contains("Cell phones"));
            Console.WriteLine(_productObject.PageTittle.Text);
        }
    }
}
