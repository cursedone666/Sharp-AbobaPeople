﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Footer
{
    public class BestSellersFooter : Footer
    {
        public BestSellersFooter(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
