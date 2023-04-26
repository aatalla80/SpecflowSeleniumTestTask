using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowSeleniumTestTask.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage(IWebDriver driver) => driver = driver;
        protected IWebDriver driver { get; }
    }
}
