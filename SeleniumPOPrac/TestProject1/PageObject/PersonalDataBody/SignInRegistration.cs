using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AunteficationAutomationPractice.PageObject.PersonalDataBody
{
    public class SignInRegistration: PersonalData
    {
        
        public SignInRegistration(IWebDriver driver)
        { 
           _driver = driver;
        }
    }
}
