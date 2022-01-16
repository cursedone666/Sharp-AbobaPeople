using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AunteficationAutomationPractice.PageObject
{
    public class SignInRegistration: RegisterBody
    {
        
        public SignInRegistration(IWebDriver driver)
        { 
           _driver = driver;
        }
    }
}
