using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace TestProject1.PageObject.Body
{
    public class BannerSummer45: Body
    {
        public BannerSummer45(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
