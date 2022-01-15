using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1.PageObject.Footer
{
    public class Footer
    {
        protected IWebDriver _driver;

        //Women button in footer
        private By _womenFooter = By.XPath("//footer[@id='footer']/div/section[2]/div/div/ul/li/a");
        //Specials button in footer
        private By _specialsFooter = By.XPath("(//a[contains(text(),'Specials')])[2]");
        //Best sellers button in footer
        private By _bestSellersFooter = By.XPath("//section[@id='block_various_links_footer']/ul/li[3]/a");
        //Our stores button in footer
        private By _ourStoresFooter = By.XPath("//section[@id='block_various_links_footer']/ul/li[4]/a");
        //New products button in footer
        private By _newProductsFooter = By.XPath("//a[contains(text(),'New products')]");
        //Contact us button in footer
        private By _contactUsFooter = By.XPath("//section[@id='block_various_links_footer']/ul/li[5]/a");
        //Terms and conditions of use button in footer
        private By _termsAndConditions = By.XPath("//section[@id='block_various_links_footer']/ul/li[6]/a");
        //About us button in footer
        private By _aboutUs = By.XPath("//section[@id='block_various_links_footer']/ul/li[7]/a");
        //Site map button in footer
        private By _siteMap = By.XPath("//section[@id='block_various_links_footer']/ul/li[8]/a");
        //My orders button in footer
        private By _myOrders = By.XPath("//footer[@id='footer']/div/section[5]/div/ul/li/a");
        //My account button in footer
        private By _myAccountFooter = By.XPath("//footer[@id='footer']/div/section[5]/h4/a");
        //My credit slips button in footer
        private By _myCreditSlips = By.XPath("//footer[@id='footer']/div/section[5]/div/ul/li[2]/a");
        //My adresses button in footer
        private By _myAdresses = By.XPath("//footer[@id='footer']/div/section[5]/div/ul/li[3]/a");
        //My presonal info button
        private By _myPersonalInfo = By.XPath("//footer[@id='footer']/div/section[5]/div/ul/li[4]/a");
        //Facebook button in footer
        private By _facebookFooter = By.XPath("//a[contains(@href, 'https://www.facebook.com/groups/525066904174158/')]");
        //Google button in footer
        private By _googleFooter = By.XPath("//a[contains(@href, 'https://plus.google.com/111979135243110831526/posts')]");
        //Twitter button
        private By _twitterFooter = By.XPath("//a[contains(@href, 'https://twitter.com/seleniumfrmwrk')]");
        //YouTube Button
        private By _youtubeFooter = By.XPath("//a[contains(@href, 'https://www.youtube.com/channel/UCHl59sI3SRjQ-qPcTrgt0tA')]");


        public AboutUs AboutUsTest()
        {
            _driver.FindElement(_aboutUs).Click();
            return new AboutUs(_driver);
        }
        public BestSellersFooter bestSellersFooterTest()
        {
            _driver.FindElement(_bestSellersFooter);
            return new BestSellersFooter(_driver);
        }
        public ContactUsFooter ContactUsFooterCheck()
        {
            _driver.FindElement(_contactUsFooter);
            return new ContactUsFooter(_driver);
        }
        public Facebook FacebookCheck()
        {
            _driver.FindElement(_facebookFooter);
            return new Facebook(_driver);
        }
        public GoogleFooter GoogleCheck()
        {
            _driver.FindElement(_googleFooter);
            return new GoogleFooter(_driver);
        }
        public MyAccountFooter MyAccCheck()
        {
            _driver.FindElement(_myAccountFooter);
            return new MyAccountFooter(_driver);
        }
        public MyAdressesFooter MyAddressCheck()
        {
            _driver.FindElement(_myAdresses);
            return new MyAdressesFooter(_driver);
        }
        public MyCreditSlips CreditSlplsCheck()
        {
            _driver.FindElement(_myCreditSlips);
            return new MyCreditSlips(_driver);
        }
        public MyOrdersFooter MyOrdersCheck()
        {
            _driver.FindElement(_myOrders);
            return new MyOrdersFooter(_driver);
        }
        public MyPersonalInfo PersonalInfoCheck()
        {
            _driver.FindElement(_myPersonalInfo);
            return new MyPersonalInfo(_driver);
        }
        public NewProducts NewProductsCheck()
        {
            _driver.FindElement(_newProductsFooter);
            return new NewProducts(_driver);
        }
        public OurStores OurStoresCheck()
        {
            _driver.FindElement(_ourStoresFooter);
            return new OurStores(_driver);
        }
        public SiteMap SiteMapCheck()
        {
            _driver.FindElement(_siteMap);
            return new SiteMap(_driver);
        }
        public Specials SpecialsCheck()
        {
            _driver.FindElement(_specialsFooter);
            return new Specials(_driver);
        }
        public TermsAndConditions TermsAndCondCheck()
        {
            _driver.FindElement(_termsAndConditions);
            return new TermsAndConditions(_driver);
        }
        public TwitterFooter TwitterCheck()
        {
            _driver.FindElement(_twitterFooter);
            return new TwitterFooter(_driver);
        }
        public Women WomenCheck()
        {
            _driver.FindElement(_womenFooter);
            return new Women(_driver);
        }
        public YouTubeFooter YTCheck()
        {
            _driver.FindElement(_youtubeFooter);
            return new YouTubeFooter(_driver);
        }
    }
}
