using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.UI.test.Pages
{
    class SearchPage<TDriver> : ISearchPage where TDriver : IWebDriver, new()
    {
        private readonly IWebDriver webDriver;
        private WebDriverWait Wait { get; set; }

        public SearchPage()
        {
            webDriver = new TDriver();
            // any time we wait we will wait for 60 seconds.
           Wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 60));
            var appSettings = ConfigurationManager.AppSettings;
            string baseUrl = appSettings["BaseUrl"];
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(baseUrl);
        }
        #region Element
        private By searchInput = By.Id("twotabsearchtextbox");
        private By searchbtn = By.XPath("//*[@id=nav - search]/form/div[2]/div/input");
        #endregion

        public void Fillinsearchbar(string Product1)
        {
            webDriver.FindElement(searchInput).SendKeys(Product1);
        }

        public void Close()
        {
            webDriver.Dispose();
        }

        public void WhenIClicksearchbutton()
        {
            webDriver.FindElement(searchbtn).Click();
        }
    }
}
