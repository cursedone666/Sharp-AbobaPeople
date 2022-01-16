using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace AunteficationAutomationPractice.PageObject
{
    public class RegisterBody
    {
        //Alexandr Zikran && Ilya Tverdohleb
        protected IWebDriver _driver;

        private string _login = "testrailmail123@gmail.com";
        private string _password = "deveducation123";
        private string _firstName = "Fedor";
        private string _lastName = "Pupkin";
        private string _dayValue = "20";
        private string _monthValue = "March";
        private string _yearValue = "1977";
        private string _company = "Deveducation";
        private string _address = "Simferopolskaya street";
        private string _address2 = "17";
        private string _city = "Dnepr";
        private string _state = "Alabama";
        private string _code = "123456";
        private string _numberMob = "+380974375856";
        private string _aliasAdress = "Aboba street";
        private string _addInfo = "aboba i boba";


        private By _signIn = By.XPath("//nav/div/a");
        private By _emailAddressRegistration = By.Id("email_create");
        private By _createAccount = By.XPath("//div[3]/button/span");
        private By _emailAddressAuthentication = By.Id("email");
        private By _passwordAuthentication = By.Id("passwd");
        private By _signInButton = By.XPath("//p[2]/button/span/i");
        private By _returnToHome = By.CssSelector(".icon-home");
        private By _personalInfoMale = By.Id("id_gender1");
        private By _personalInfoFemale = By.Id("id_gender2");
        private By _personalInfoFirstName = By.Id("customer_firstname");
        private By _personalInfoLastName = By.Id("customer_lastname");
        private By _personalInfoEmail = By.Id("email");
        private By _personalInfoPassword = By.Id("passwd");
        private By _personalInfoDay = By.Id("days");
        private By _personalInfoMonth = By.Id("months");
        private By _personalInfoYear = By.Id("years");
        private By _personalInfoNews = By.Id("newsletter");
        private By _personalInfoPartner = By.Id("optin");
        private By _addressFirstName = By.Id("firstname");
        private By _addressLastName = By.Id("lastname");
        private By _addressCompany = By.Id("company");
        private By _addressAddress = By.Id("address1");
        private By _addressAddress2 = By.Id("address2");
        private By _addressCity = By.Id("city");
        private By _addressState = By.Id("id_state");
        private By _addressCode = By.Id("postcode");
        //
        private By _phone = By.Id("phone");
        private By _additionalInfo =By.Id("other");
        private By _phoneMobile = By.Id("phone_mobile");
        private By _adressAlias = By.Id("alias");

        public AdditionalInfo AdditionalInfoCheck()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_additionalInfo).Click();
            _driver.FindElement(_additionalInfo).SendKeys(_addInfo);
            return new AdditionalInfo(_driver);
        }

        public HomePhone HomePhoneCheck()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_phone).Click();
            _driver.FindElement(_phone).SendKeys(_numberMob);
            return new HomePhone(_driver);
        }
        public MobilePhone MobilePhoneCheck()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_phoneMobile).Click();
            _driver.FindElement(_phoneMobile).SendKeys(_numberMob);
            return new MobilePhone(_driver);
        }
        public AddressAlias AddressAliasCheck()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_adressAlias).Click();
            _driver.FindElement(_adressAlias).SendKeys(_aliasAdress);
            return new AddressAlias(_driver);
        }

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
        public PersonalInfoMale PersonalInfoMale()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoMale).Click();
            return new PersonalInfoMale(_driver);
        }
        public PersonalInfoFemale PersonalInfoFemale()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoFemale).Click();
            return new PersonalInfoFemale(_driver);
        }
        public PersonalInfoFirstName PersonalInfoFirstName()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoFirstName).SendKeys(_firstName);
            return new PersonalInfoFirstName(_driver);
        }
        public PersonalInfoLastName PersonalInfoLastName()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoLastName).SendKeys(_lastName);
            return new PersonalInfoLastName(_driver);
        }
        public PersonalInfoEmail PersonalInfoEmail()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoEmail).SendKeys(_login);
            return new PersonalInfoEmail(_driver);
        }
        public PersonalInfoPassword PersonalInfoPassword()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_personalInfoPassword).SendKeys(_password);
            return new PersonalInfoPassword(_driver);
        }
        public PersonalInfoDay PersonalInfoDay()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_personalInfoDay).Click();
            _driver.FindElement(_personalInfoDay).SendKeys(_dayValue);
            return new PersonalInfoDay(_driver);
        }
        public PersonalInfoMonth PersonalInfoMonth()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_personalInfoMonth).Click();
            _driver.FindElement(_personalInfoMonth).SendKeys(_monthValue);
            return new PersonalInfoMonth(_driver);
        }
        public PersonalInfoYear PersonalInfoYear()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_personalInfoYear).Click();
            _driver.FindElement(_personalInfoYear).SendKeys(_yearValue);
            return new PersonalInfoYear(_driver);
        }
        public PersonalInfoNews PersonalInfoNews()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_personalInfoNews).Click();
            return new PersonalInfoNews(_driver);
        }
        public PersonalInfoPartner PersonalInfoPartner()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_personalInfoPartner).Click();
            return new PersonalInfoPartner(_driver);
        }
        public AddressFirstName AddressFirstName()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressFirstName).SendKeys(_firstName);
            return new AddressFirstName(_driver);
        }
        public AddressLastName AddressLastName()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressLastName).SendKeys(_lastName);
            return new AddressLastName(_driver);
        }
        public AddressCompany AddressCompany()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressCompany).SendKeys(_company);
            return new AddressCompany(_driver);
        }
        public AddressAddress AddressAddress()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressAddress).SendKeys(_address);
            return new AddressAddress(_driver);
        }
        public AddressAddress2 AddressAddress2()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressAddress2).SendKeys(_address2);
            return new AddressAddress2(_driver);
        }
        public AddressCity AddressCity()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressCity).SendKeys(_city);
            return new AddressCity(_driver);
        }
        public AddressState AddressState()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressState).SendKeys(_state);
            return new AddressState(_driver);
        }
        public AddressCode AddressCode()
        {
            _driver.FindElement(_signIn).Click();
            _driver.FindElement(_emailAddressRegistration).SendKeys(_login);
            _driver.FindElement(_createAccount).Click();
            _driver.FindElement(_addressCode).SendKeys(_code);
            return new AddressCode(_driver);
        }
    }
}
