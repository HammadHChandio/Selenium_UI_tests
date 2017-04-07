using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Selenium.UI.test.Drivers;

namespace Selenium.UI.test.Steps
{
    [Binding]
    public class SearchBarSteps
    {
       

        [Given(@"Amazon site is available")]
        public void GivenAmazonSiteIsAvailable()
        {
            Driverhook.driver.Navigate().GoToUrl("https://www.amazon.co.uk");
        }
        
        [Given(@"Search bar is available")]
        public void GivenSearchBarIsAvailable()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to search for ""(.*)""")]
        public void GivenIWantToSearchFor(string item)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see result for thinkpads")]
        public void ThenIShouldSeeResultForThinkpads()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
