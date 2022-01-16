using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AunteficationAutomationPractice.PageObject
{
    public class PersonalInfoPartner : RegisterBody
    {
        public PersonalInfoPartner(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
