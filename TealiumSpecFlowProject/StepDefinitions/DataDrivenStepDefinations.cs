using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TealiumSpecFlowProject.StepDefinitions
{
    [Binding]
    public class DataDrivenStepDefinations
    {
        private IWebDriver _driver;

        public DataDrivenStepDefinations(IWebDriver driver)
        {
            this._driver= driver;
        }
        [Then(@"Choose product details for '([^']*)'")]
        public void ThenChooseProductDetailsFor(string searchKey)
        {
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath("//input[@class='input-text required-entry']")).SendKeys(searchKey);
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath("//input[@class='input-text required-entry']")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }


    }
}
