using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products.SmallWindow
{
    public class ContinueShopping : SmallWindow
    {
        public ContinueShopping(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
