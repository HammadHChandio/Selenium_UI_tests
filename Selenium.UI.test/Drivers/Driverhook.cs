//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using TechTalk.SpecFlow;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Remote;

//namespace Selenium.UI.test.Drivers
//{
//    [Binding]
//    public sealed class Driverhook
//    {
//        // public static IWebDriver driver = new RemoteWebDriver(new Uri("http://192.168.0.49:4444/wd/hub"), DesiredCapabilities.Firefox());


//        //public static IWebDriver driver = new RemoteWebDriver(new Uri("http://192.168.0.49:4444/wd/hub"));

//       public static IWebDriver driver;

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            DesiredCapabilities cap = DesiredCapabilities.Firefox();
//            cap.SetCapability("browserName", "chrome");
//            cap.SetCapability("seleniumProtocol", "WebDriver");
//            cap.SetCapability("version", "ANY");
//            cap.SetCapability("maxInstances", "1");
//            cap.SetCapability("maxsession", "3");

//        driver = new RemoteWebDriver(new Uri("http://192.168.0.21:4444/wd/hub"), DesiredCapabilities.Chrome());
//    }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            driver.Quit();
//        }
//    }
//}
