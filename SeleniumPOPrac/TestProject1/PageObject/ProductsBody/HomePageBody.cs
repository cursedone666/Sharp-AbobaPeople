using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products
{
    public class HomePageBody
    {
        //Natasha Gorb
        protected IWebDriver _driver;

        private By _clickHomePage = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/blockbanner/img/sale70.png')]");
        private By _clickSeleniumFramework = By.XPath("//a[contains(text(),'Selenium Framework')]");
        private By _clickPopular = By.XPath("//a[contains(text(),'Popular')]");     
        private By _clickBestSellers = By.XPath("//a[contains(text(),'Best Sellers')]");
        private By _checkingClickFotoFirstElementProduct = By.XPath("//ul[@id='homefeatured']/li/div/div/div/a/img");
        private By _checkingShoppingCartButtonFirstElement = By.XPath("//ul[@id='homefeatured']/li/div/div[2]/div[2]/a/span");
        private By _checkingClickNameFirstElementProduct = By.LinkText("Faded Short Sleeve T-shirts");
        private By _checkingMoreButtonFirstElement = By.XPath("//span[contains(.,'More')]ts']");

        public HomePageBody clickHomePage()
        {
            _driver.FindElement(_clickHomePage).Click();
            return this;
        }
        public SeleniumFramework clickSeleniumFrameworks()
        {
            _driver.FindElement(_clickSeleniumFramework).Click();
            return new SeleniumFramework(_driver);
        }       
        public Popular clickPopular()
        {
            _driver.FindElement(_clickPopular).Click();
            return new Popular(_driver);
        }      
        public Popular CheckingClickFotoFirstElementProduct()
        {
            _driver.FindElement(_checkingClickFotoFirstElementProduct).Click();
            return new Popular(_driver);
        }      
        public Popular CheckingShoppingCartButtonFirstElement()
        {
            _driver.FindElement(_checkingShoppingCartButtonFirstElement).Click();
            return new Popular(_driver);
        }
        public Popular CheckingClickFotoProduct()
        {
            for (int i = 1; i < 7; i++)
            {
                _driver.FindElement(By.XPath("//ul[@id='homefeatured']/li[" + i + "]/div/div/div/a/img")).Click();
            }
            return new Popular(_driver);
        }       
        public Popular CheckingShoppingCartButton()
        {
            for (int i = 1; i < 7; i++)
            {
                _driver.FindElement(By.XPath("//ul[@id='homefeatured']/li[" + i + "]/div/div[2]/div[2]/a/span")).Click();
            }
            return new Popular(_driver);
        }
        public Popular CheckingClickNameFirstElementProduct()
        {
            _driver.FindElement(_checkingClickNameFirstElementProduct).Click();
            return new Popular(_driver);
        }
        public Popular CheckingMoreButtonFirstElement()
        {
            _driver.FindElement(_checkingMoreButtonFirstElement).Click();
            return new Popular(_driver);
        }
        public Popular CheckingClickNameProduct()
        {
            for (int i = 1; i < 7; i++)
            {
                _driver.FindElement(By.XPath("//ul[@id='homefeatured']/li[" + i + "]/div/div[2]/h5/a")).Click();
            }
            return new Popular(_driver);
        }
        public Popular CheckingMoreButton()
        {
            for (int i = 1; i < 7; i++)
            {
                _driver.FindElement(By.XPath("//ul[@id='homefeatured']/li[" + i + "]/div/div[2]/div[2]/a[2]/span")).Click();
            }
            return new Popular(_driver);
        }
        public BestSellers clickBestSellers()
        {
            _driver.FindElement(_clickBestSellers).Click();
            return new BestSellers(_driver);
        }
    }
}
