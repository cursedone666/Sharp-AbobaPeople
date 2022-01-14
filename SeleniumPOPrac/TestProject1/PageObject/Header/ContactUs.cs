using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace TestProject1.PageObject
{
    public class ContactUs : Header
    {
        

        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
