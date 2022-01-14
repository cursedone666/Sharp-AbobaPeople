using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.PageObject
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
