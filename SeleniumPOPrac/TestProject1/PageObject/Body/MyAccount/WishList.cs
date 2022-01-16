using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Body.MyAccount
{
    public class WishList : MyAccount
    {
        public WishList(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}