using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Body.MyAccount
{
    public class Personalinformation : MyAccount
    {
        public Personalinformation(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}