using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_19.PageObject.Products.LargeWindow
{
    public class LargeWindow
    {
        //Natasha Gorb
        protected IWebDriver _driver;

        private By _checkingAddCart = By.XPath("//p[@id='add_to_cart']/button/span");
        private By _checkingAddWishList = By.XPath("//a[contains(text(),'Add to wishlist')]");
        private By _clickButtonHome = By.XPath("//div[@id='columns']/div/a/i");
        private By _clickPrint = By.XPath("(//a[contains(text(),'Print')])[6]");
        private By _checkingQuantityReduction = By.XPath("//p[@id='quantity_wanted_p']/a/span/i");
        private By _checkingIncreaseQuantityGoods = By.XPath("//p[@id='quantity_wanted_p']/a[2]/span");
        private By _checkingSendFriend = By.XPath("//a[@id='send_friend_button']");
        private By _checkingSizeSelection = By.XPath("//div[@id='uniform-group_1']/select");       
        private By _checkingSocialNetworkingChoicesTweet = By.XPath("//div[@id='center_column']/div/div/div[3]/p[7]/button");
        private By _clickViewLarger = By.XPath("//div[3]/div/div/div/div[2]/div/span/span");

        public AddCart CheckingAddCart()
        {
            _driver.FindElement(_checkingAddCart).Click();
            return new AddCart(_driver);
        }
        public AddWishlist CheckingAddWishList()
        {
            _driver.FindElement(_checkingAddWishList).Click();
            return new AddWishlist(_driver);
        }
        public Color CheckingColorChanges()
        {
            for (int i = 1; i < 16; i++)
            {
                _driver.FindElement(By.XPath("//a[@id='color_" + i +"']")).Click();
            }
            return new Color(_driver);
        }
        public FotoProduct CheckingClickFotoProductFirst()
        {
            for (int i = 1; i < 5; i++)
            {
                _driver.FindElement(By.XPath("(//img[@alt='Faded Short Sleeve T-shirts'])[" + i +"]")).Click();
            }
            return new FotoProduct(_driver);
        }
        public FotoProduct CheckingClickFotoProductSecond()
        {
            for (int i = 1; i < 4; i++)
            {
                _driver.FindElement(By.XPath("(//img[@alt='Blouse'])[" + i + "]")).Click();
            }
            return new FotoProduct(_driver);
        }
        public FotoProduct CheckingClickFotoProductThirdAndFourth()
        {
            for (int i = 1; i < 5; i++)
            {
                _driver.FindElement(By.XPath("(//img[@alt='Printed Dress'])[" + i + "]")).Click();
            }
            return new FotoProduct(_driver);
        }      
        public FotoProduct CheckingClickFotoProductFifthAndSixth()
        {
            for (int i = 1; i < 9; i++)
            {
                _driver.FindElement(By.XPath("((//img[@alt='Printed Summer Dress'])[" + i + "]")).Click();
            }
            return new FotoProduct(_driver);
        }       
        public FotoProduct CheckingClickFotoProductSeventh()
        {
            for (int i = 1; i < 5; i++)
            {
                _driver.FindElement(By.XPath("(//img[@alt='Printed Chiffon Dress'])[" + i + "]")).Click();
            }
            return new FotoProduct(_driver);
        }
        public Home ClickButtonHome()
        {
            _driver.FindElement(_clickButtonHome).Click();
            return new Home(_driver);
        }
        public Print ClickPrint()
        {
            _driver.FindElement(_clickPrint).Click();
            return new Print(_driver);
        }
        public Quantity CheckingQuantityReduction()
        {
            _driver.FindElement(_checkingQuantityReduction).Click();
            _driver.FindElement(_checkingIncreaseQuantityGoods).Click();
            return new Quantity(_driver);
        }
        public SendFriend CheckingSendFriends()
        {
            _driver.FindElement(_checkingSendFriend).Click();            
            return new SendFriend(_driver);
        }
        public Size CheckingSizeSelection()
        {
            _driver.FindElement(_checkingSizeSelection).Click();            
            return new Size(_driver);
        }
        public SocialMedia CheckingSocialNetworkingChoicesTweet()
        {
            _driver.FindElement(_checkingSocialNetworkingChoicesTweet).Click();            
            return new SocialMedia(_driver);
        }
        public SocialMedia CheckingSelectionOtherSocialNetworksList()
        {
            for (int i = 1; i < 4; i++)
            {
                _driver.FindElement(By.XPath("//div[@id='center_column']/div/div/div[3]/p[7]/button[" + i +"]")).Click();
            }
            return new SocialMedia(_driver);
        }
        public BreadCrumbs CheckingBreadCrumbs()
        {
            for (int i = 1; i < 4; i++)
            {
                _driver.FindElement(By.XPath("//div[@id='columns']/div/a[" + i + "]")).Click();
            }
            return new BreadCrumbs(_driver);
        }
        public ViewLarger ClickViewLarger()
        {
            _driver.FindElement(_clickViewLarger).Click();
            return new ViewLarger(_driver);
        }
    }
}
