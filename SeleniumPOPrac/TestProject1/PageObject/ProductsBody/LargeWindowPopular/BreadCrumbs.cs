﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products.LargeWindow
{
    public class BreadCrumbs : LargeWindow
    {
        public BreadCrumbs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
