using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace AunteficationAutomationPractice.PageObject.PersonalDataBody
{
    public class PersonalData
    {
        //Alexandr Zikran
        protected IWebDriver _driver;

        private string _login = "testrailmail123@gmail.com";
        private string _password = "deveducation123";

        private By _signIn = By.XPath("//nav/div/a");
        private By _emailAddressRegistration = By.Id("email_create");
        private By _createAccount = By.XPath("//div[3]/button/span");
        private By _emailAddressAuthentication = By.Id("email");
        private By _passwordAuthentication = By.Id("passwd");
        private By _signInButton = By.XPath("//p[2]/button/span/i");
        private By _returnToHome = By.CssSelector(".icon-home");

        public SignInRegistration SignInRegistration()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            return new SignInRegistration(_driver);
        }
        public Authentication Authentication()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressAuthentication).SendKeys(_login);
            _driver.FindElement(_passwordAuthentication).SendKeys(_password);
            _driver.FindElement(_signInButton).Click();
            return new Authentication(_driver);
        }
        public ReturnToHome ReturnToHome()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_returnToHome).Click();
            return new ReturnToHome(_driver);
        }
    }
}
