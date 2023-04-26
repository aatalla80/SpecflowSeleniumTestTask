using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowSeleniumTestTask.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecflowSeleniumTestTask.StepDefinitions
{
    [Binding]
    public class ShoppingCartFeatureStepDefinitions
    {



        public ShoppingCartFeatureStepDefinitions()
        {
            driver = new ChromeDriver();
            shoppingCartPage = new ShoppingCartPage(driver);
       
        }
       
        public ShoppingCartPage shoppingCartPage { get; set; }


        private IWebDriver driver;
        private string baseURL = "https://cms.demo.katalon.com";
       

        [Given(@"I add (.*) random items to my cart")]
        public void GivenIAddRandomItemsToMyCart(int p0)
        {
            
            driver.Url = $"{baseURL}";
            
            for(int i = 0; i < p0; i++)
            {
                Random random = new Random();
                List<int> urlItemNumber = new() { 54, 26, 27, 25, 66, 22, 51, 27, 57, 15, 16, 19, 45, 20, 21, 48, 13, 14,};
                int value = urlItemNumber[random.Next(urlItemNumber.Count)];
                driver.Url = $"{baseURL}/?add-to-cart={value}";
            }       
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            driver.Url = $"{baseURL}/cart";
        }

        [Then(@"I find total (.*) items in my cart")]
        public void ThenIFindTotalItemsInMyCart(int p0)
        {
            int result = shoppingCartPage.CountTheNumberOfCartItems;

            Assert.IsTrue(p0 == result);
        }

        [When(@"I search for lowest price item")]
        public void WhenISearchForLowestPriceItem()
        {
            throw new PendingStepException();
        }

        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
            throw new PendingStepException();
        }

        [Then(@"I am able to verify (.*) items in my cart")]
        public void ThenIAmAbleToVerifyItemsInMyCart(int p0)
        {
            throw new PendingStepException();
        }
    }
}
