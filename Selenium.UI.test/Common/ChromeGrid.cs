using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridSpecFlow.Common
{
    class ChromeGrid:RemoteWebDriver
    {
        public ChromeGrid() : base(new Uri("http://192.168.0.21:4444/wd/hub"), DesiredCapabilities.Chrome())
        {

        }


    }
}
