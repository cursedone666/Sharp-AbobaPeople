using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestProject1.PageObject.Body
{
    //Alexandr Zikran
    public class Body
    {
        protected IWebDriver _driver;

        private By _slyderSimple1 = By.XPath("//li[2]/div");
        private By _slyderSimple2 = By.XPath("//div/ul/li[3]/div");
        private By _slyderSimple3 = By.XPath("//li[4]/div");
        private By _sale25 = By.CssSelector("#htmlcontent_top .htmlcontent-item-1 .item-img");
        private By _summer45 = By.CssSelector("#htmlcontent_top .htmlcontent-item-2 .item-img");
        private By _topTrends = By.CssSelector("#htmlcontent_home .htmlcontent-item-1 .item-img");
        private By _mensCoats = By.CssSelector("#htmlcontent_home .htmlcontent-item-2 .item-img");
        private By _womensCoats = By.CssSelector(".htmlcontent-item-3 .item-img");
        private By _sunGlasses = By.CssSelector(".htmlcontent-item-4 .item-img");
        private By _handBags = By.CssSelector(".htmlcontent-item-5 .item-img");

        public SlyderSymple1 Symple1()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_slyderSimple1)).Click();
            return new SlyderSymple1(_driver);
        }
        public SlyderSymple2 Symple2()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_slyderSimple2)).Click();
            return new SlyderSymple2(_driver);
        }
        public SlyderSymple3 Symple3()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_slyderSimple3)).Click();
            return new SlyderSymple3(_driver);
        }

        public Banner25Sale Banner25Sale()
        {
            _driver.FindElement(_sale25).Click();
            return new Banner25Sale(_driver);
        }
        public BannerSummer45 BannerSummer45()
        {
            _driver.FindElement(_summer45).Click();
            return new BannerSummer45(_driver);
        }
        public BannerTopTrends BannerTopTrends()
        {
            _driver.FindElement(_topTrends).Click();
            return new BannerTopTrends(_driver);
        }
        public BannerMensCoats BannerMensCoats()
        {
            _driver.FindElement(_mensCoats).Click();
            return new BannerMensCoats(_driver);
        }
        public BannerWomensCoats BannerWomensCoats()
        {
            _driver.FindElement(_womensCoats).Click();
            return new BannerWomensCoats(_driver);
        }
        public BannerSunGlasses BannerSunGlasses()
        {
            _driver.FindElement(_sunGlasses).Click();
            return new BannerSunGlasses(_driver);
        }
        public BannerHandBags BannerHandBags()
        {
            _driver.FindElement(_handBags).Click();
            return new BannerHandBags(_driver);
        }
    }
}
