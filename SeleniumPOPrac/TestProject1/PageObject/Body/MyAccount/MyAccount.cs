using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Body.MyAccount
{
    //Ilya Tverdohleb
    public class MyAccount
    {
        protected IWebDriver _driver;

        private By _orderHistory = By.XPath("//div[@id='center_column']/div/div/ul/li/a/span");
        private By _myCredSlips = By.XPath("//div[@id='center_column']/div/div/ul/li[2]/a/span");
        private By _myAdresses = By.XPath("//div[@id='center_column']/div/div/ul/li[3]/a/span");
        private By _myPersonalInfo = By.XPath("//div[@id='center_column']/div/div/ul/li[4]/a/span");
        private By _myWishList = By.XPath("//div[@id='center_column']/div/div[2]/ul/li/a/span");
        private By _homeReturn = By.XPath("//div[@id='center_column']/ul/li/a/span");
        private By _myProfile = By.XPath("//header[@id='header']/div[2]/div/div/nav/div/a/span");

        public ReturnHome HomeReturnButton()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_homeReturn).Click();
            return new ReturnHome(_driver);
        }

        public WishList WishListCheck()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_myWishList).Click();
            return new WishList(_driver);
        }

        public Personalinformation PersonalINfoCheck()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_myPersonalInfo).Click();
            return new Personalinformation(_driver);
        }

        public OrderHistory OrderHistoryCheck()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_orderHistory).Click();
            return new OrderHistory(_driver);
        }
        public MyProfile MyProfileCheck()
        {
            _driver.FindElement(_myProfile).Click();
            return new MyProfile(_driver);
        }
        public CredSlips CreditSlipsCheck()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_myCredSlips).Click();

            return new CredSlips(_driver);
        }
        public MyAdresses MyAdressesCheck()
        {
            _driver.FindElement(_myProfile).Click();
            _driver.FindElement(_myAdresses).Click();
            return new MyAdresses(_driver);
        }
    }
}
