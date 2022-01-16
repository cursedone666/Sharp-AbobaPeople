using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products
{
    public class Popular : HomePageBody
    {
        public Popular(IWebDriver driver)
        {
            _driver = driver;
        }
       
    }
}
