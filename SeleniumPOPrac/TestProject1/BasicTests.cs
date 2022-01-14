using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1
{
    public class BasicTests : IDisposable
    {
        private IWebDriver _driver;

        public IWebDriver StartDriver(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            return _driver;
        }
        public void Dispose()
        {
            _driver.Quit();
        }

    }
}