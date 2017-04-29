using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Selenium.UI.test.Pages
{

    public interface ISearchPage
    {
        void Fillinsearchbar(string Product1);
        void Close();
        void WhenIClicksearchbutton();
        

    }


    public class BasePage
    {
        protected IWebDriver webDriver;
        protected int secondTimeOut;
        public BasePage()
        {


        }
        public void Init()
        {
            var appSettings = ConfigurationManager.AppSettings;
            secondTimeOut = Convert.ToInt32(appSettings["TimeOut"]);

        }
        public void WaitForPageElement(By byElement)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(secondTimeOut));

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(byElement));
            }
            catch (WebDriverTimeoutException)
            {
                //add throw new exception message
            }

        }



    }
}
