using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AunteficationAutomationPractice.PageObject
{
    public class PersonalInfoPassword : RegisterBody
    {
        public PersonalInfoPassword(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
