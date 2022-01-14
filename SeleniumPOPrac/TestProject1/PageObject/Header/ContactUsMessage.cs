using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    public class ContactUsMessage : Header
    {
        

        public ContactUsMessage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
