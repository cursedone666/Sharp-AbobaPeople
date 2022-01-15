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
    }
}
