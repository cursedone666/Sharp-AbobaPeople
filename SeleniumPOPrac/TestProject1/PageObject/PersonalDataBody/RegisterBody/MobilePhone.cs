using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AunteficationAutomationPractice.PageObject
{
    public class MobilePhone : PersonalData
    {
        public MobilePhone(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}