using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products.LargeWindow
{
    public class Print : LargeWindow
    {
        public Print(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
