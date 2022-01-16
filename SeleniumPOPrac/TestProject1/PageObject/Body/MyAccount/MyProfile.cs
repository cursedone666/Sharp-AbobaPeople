using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Body.MyAccount
{
    public class MyProfile : MyAccount
    {
        public MyProfile(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}