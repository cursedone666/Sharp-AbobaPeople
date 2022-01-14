using System;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.PageObject;

namespace TestProject1
{
    public class UnitTest1 : BasicTests
    {
        [Fact]
        public void ContactUsTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.ContactUsClick();
        }

        [Fact]
        public void GetSavingsTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.getSavingsClick();
        }

        [Fact]
        public void SignInClickTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.signInClick();
        }

        [Fact]
        public void SendMessageContactUsTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.ContactUsClick();
            HeaderPart.sendingMessageClick();
        }

        [Fact]
        public void LogoClickTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.logoClick();
        }

        [Fact]
        public void SearchRequestTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.searchRequest();
        }

        [Fact]
        public void SearchLoopRequest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);
            HeaderPart.SearchLoopClick();
        }

        [Fact]
        public void WomenDropDownTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenHover();
        }

        [Fact]
        public void WomenTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.Women();
        }

        [Fact]
        public void WomenTshirtHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenTshirtHover();
        }

        [Fact]
        public void WomenBlouseHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenBlouseHover();
        }

        [Fact]
        public void WomenEvDressTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenEveningDressHoverTest();
        }

        [Fact]
        public void WomenSummerDressTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenSummerHoverTest();
        }

        [Fact]
        public void WomenCasualDressTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.WomenCasualDressHoverTest();
        }

        [Fact]
        public void DressesTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.Dresses();
        }

        [Fact]
        public void DressesHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.DressesHoverCheck();
        }

        [Fact]
        public void CasualDressHover()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.CasualDressesHoverTest();
        }

        [Fact]
        public void EveningDressHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.EveningDressesHoverTest();
        }

        [Fact]
        public void SummerlDressHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.SummerDressesHoverTest();
        }

        [Fact]
        public void ThirtTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.TShirt();
        }

        [Fact]
        public void ThirtHoverTest()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.TshirtHover();
        }

        [Fact]
        public void CartClick()
        {
            IWebDriver driver = StartDriver("http://automationpractice.com/index.php");
            Header HeaderPart = new HomePage(driver);

            HeaderPart.CartClick();
        }

        

    }
}
