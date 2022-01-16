using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AunteficationAutomationPractice.PageObject
{
    public class HomePhone : PersonalData
    {
        public HomePhone(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
