using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace TestProject1.PageObject
{
    public class Header
    {
        protected IWebDriver _driver;
        //Main buttons
        private By _contactUsClick = By.XPath("//div[2]/a");
        private By _getSaveings = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/blockbanner/img/sale70.png')]");
        private By _signIn = By.XPath("//a[contains(text(),'Sign in')]");
        //Contact us module == sending message
        private By _sendMessageEMail = By.XPath("//input[@id='email']");
        private By _sendOrderRef = By.XPath("//input[@id='id_order']");
        private By _sendMessageClick = By.XPath("//button[@id='submitMessage']/span");
        private By _sendMessageInput = By.XPath("//textarea[@id='message']");
        private By _sendMessageOption = By.XPath("//select");
        //Logo actions
        private By _logoClick = By.XPath("//img[@alt='My Store']");
        //Search actions
        private By _searchClick = By.Id("search_query_top");
        private By _searchLoopClick = By.Name("submit_search");
        //Women part
        private By _womenClick = By.XPath("//a[contains(text(),'Women')]");
        private By _womenTshirt = By.XPath("//a[contains(text(),'T-shirts')]");
        private By _womenBlouses = By.XPath("//a[contains(text(),'Blouses')]");
        private By _womenSummerDress = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _womenEveningDress = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private By _womenCasualDresse = By.XPath("//a[contains(text(),'Casual Dresses')]");
        //Dresses part
        private By _dressesClick = By.XPath("(//a[contains(text(),'Dresses')])[5]");
        private By _casualDresses = By.XPath("(//a[contains(text(),'Casual Dresses')])[2]");
        private By _eveningDresses = By.XPath("(//a[contains(text(),'Evening Dresses')])[2]");
        private By _summerDresses = By.XPath("(//a[contains(text(),'Summer Dresses')])[2]");
        //T-shirts part
        private By _tShirtClick = By.XPath("(//a[contains(text(),'T-shirts')])[2]");
        //Cart part
        private By _cartClick = By.XPath("//header[@id='header']/div[3]/div/div/div[3]/div/a");


        public ContactUs ContactUsClick()
        {
            _driver.FindElement(_contactUsClick).Click();
            return new ContactUs(_driver);
        }

        public GetSavingsNow getSavingsClick()
        {
            _driver.FindElement(_getSaveings).Click();
            return new GetSavingsNow(_driver);
        }

        public SignIn signInClick()
        {
            _driver.FindElement(_signIn).Click();
            return new SignIn(_driver);
        }

        public ContactUsMessage sendingMessageClick()
        {
            _driver.FindElement(_sendMessageOption).Click();
            _driver.FindElement(_sendMessageOption).SendKeys(Keys.ArrowDown);
            _driver.FindElement(_sendMessageOption).SendKeys(Keys.Enter);
            _driver.FindElement(_sendMessageEMail).Click();
            _driver.FindElement(_sendMessageEMail).SendKeys("aboba@gmail.com");
            _driver.FindElement(_sendOrderRef).Click();
            _driver.FindElement(_sendOrderRef).SendKeys("asgfasggas");
            _driver.FindElement(_sendMessageInput).Click();
            _driver.FindElement(_sendMessageInput).SendKeys("BOGDAN POSHADI DAI DZ NA PONEDELNIK");
            _driver.FindElement(_sendMessageClick).Click();
            return new ContactUsMessage(_driver);
        }
        public Logo logoClick()
        {
            _driver.FindElement(_logoClick).Click();
            return new Logo(_driver);
        }

        public Search searchRequest()
        {
            _driver.FindElement(_searchClick).Click();
            _driver.FindElement(_searchClick).SendKeys("dress");
            _driver.FindElement(_searchClick).SendKeys(Keys.Enter);
            return new Search(_driver);
        }

        public Search SearchLoopClick()
        {
            _driver.FindElement(_searchClick).Click();
            _driver.FindElement(_searchClick).SendKeys("aboba");
            _driver.FindElement(_searchLoopClick).Click();
            return new Search(_driver);
        }

        public WomenPart Women()
        {
            _driver.FindElement(_womenClick).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenHover()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenClick).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenTshirtHover()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenTshirt).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenBlouseHover()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenBlouses).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenEveningDressHoverTest()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenEveningDress).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenCasualDressHoverTest()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenCasualDresse).Click();

            return new WomenPart(_driver);
        }

        public WomenPart WomenSummerHoverTest()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_womenClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_womenSummerDress).Click();

            return new WomenPart(_driver);
        }

        public DressesPart Dresses()
        {
            _driver.FindElement(_dressesClick).Click();
            return new DressesPart(_driver);
        }

        public DressesPart DressesHoverCheck()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dressesClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_dressesClick).Click();
            return new DressesPart(_driver);
        }

        public DressesPart EveningDressesHoverTest()
        {
            

            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dressesClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_eveningDresses).Click();
            return new DressesPart(_driver);
        }

        public DressesPart SummerDressesHoverTest()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dressesClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_summerDresses).Click();
            return new DressesPart(_driver);
        }

        public DressesPart CasualDressesHoverTest()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dressesClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_casualDresses).Click();
            return new DressesPart(_driver);
        }

        public TShirtPart TShirt()
        {
            _driver.FindElement(_tShirtClick).Click();
            return new TShirtPart(_driver);
        }

        public TShirtPart TshirtHover()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_tShirtClick);
            act.MoveToElement(element).Perform();
            _driver.FindElement(_tShirtClick).Click();
            return new TShirtPart(_driver);
        }

        public CartPart CartClick()
        {
            _driver.FindElement(_cartClick).Click();
            return new CartPart(_driver);
        }

    }
}
