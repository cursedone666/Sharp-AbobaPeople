using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products.SmallWindow
{
    public class SmallWindow
    {
        //Natasha Gorb
        protected IWebDriver _driver;
       
        private By _clickCloseButton = By.XPath("//body[@id='index']/div[2]/div/div/a");
        private By _clickContinueShopping = By.XPath("//div[@id='layer_cart']/div/div[2]/div[4]/span/span");
        private By _checkingDelete = By.XPath("//a[@id='1_1_0_0']/i");
        private By _clickProceedCheckout = By.XPath("//div[@id='layer_cart']/div/div[2]/div[4]/a/span");
                     
        public Close ClickCloseButton()
        {
            _driver.FindElement(_clickCloseButton).Click();
            return new Close(_driver);
        }
        public ContinueShopping ClickContinueShopping()
        {
            _driver.FindElement(_clickContinueShopping).Click();
            return new ContinueShopping(_driver);
        }
        public Delete CheckingDelete()
        {
            _driver.FindElement(_checkingDelete).Click();
            return new Delete(_driver);
        }
        public ProceedCheckout ClickProceedCheckout()
        {
            _driver.FindElement(_clickProceedCheckout).Click();
            return new ProceedCheckout(_driver);
        }

    }
}
