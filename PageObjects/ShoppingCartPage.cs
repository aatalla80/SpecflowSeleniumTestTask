using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowSeleniumTestTask.PageObjects
{
    public class ShoppingCartPage : BasePage
    {
        public ShoppingCartPage(IWebDriver driver) : base(driver) 
        {
        }

        By CartItem = By.CssSelector("#post-8 > div > div > form > table > tbody > tr:nth-child(1) > td.product-remove > a");

        public int CountTheNumberOfCartItems => driver.FindElements(CartItem).;
    }
}
