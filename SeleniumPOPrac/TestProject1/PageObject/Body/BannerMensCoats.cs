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
    public class BannerMensCoats : Body
    {
        public BannerMensCoats(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
