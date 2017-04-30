using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Selenium.UI.test.Pages;
using System.Configuration;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using SeleniumGridSpecFlow.Common;
using Selenium.UI.test.Model;

namespace Selenium.UI.test.StepsDef
{
    [Binding]
    public class SearchBarSteps : Steps
    {
        private ISearchPage _page;
        [BeforeScenario]
        public void Setup()
        {
            System.Console.Write("Scenarios Setup.\r\n");

            var appSettings = ConfigurationManager.AppSettings;
            string[] browsers = appSettings["Browsers"].Split(';');

            var pages = new ConcurrentStack<ISearchPage>();
            foreach (string browser in browsers)
            {
                if (browser == "Chrome")
                    Parallel.Invoke(() => pages.Push(new SearchPage<ChromeGrid>()));
                if (browser == "Firefox")
                    Parallel.Invoke(() => pages.Push(new SearchPage<FireFoxGrid>()));
                if (browser == "IE")
                    Parallel.Invoke(() => pages.Push(new SearchPage<InternetExplorerGrid>()));
            }
            var parallelPage = new ParallelModel<ISearchPage>(pages.ToArray());
            _page = parallelPage.Cast();

        }
        [AfterScenario]
        public void Teardown()
        {
            //Console.Write("Scenarios tear down.\r\n");
            _page.Close();

        }


        [Given(@"Amazon site is available")]
        public void GivenAmazonSiteIsAvailable()
        {
          //
        }
        
        [Given(@"Search bar is available")]
        public void GivenSearchBarIsAvailable()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to search for ""(.*)""")]
        public void GivenIWantToSearchFor(string item)
        {
            _page.Fillinsearchbar(item);
        }
        
        [When(@"I press search")]
        public void WhenIPressSearch()
        {
           //_page.WhenIClicksearchbutton();
        }
        
        [Then(@"I should see result for thinkpads")]
        public void ThenIShouldSeeResultForThinkpads()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
