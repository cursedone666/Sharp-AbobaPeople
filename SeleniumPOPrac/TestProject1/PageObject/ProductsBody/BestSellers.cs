using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products
{
    public class BestSellers : HomePageBody
    {
        public BestSellers(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
