using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TealiumSpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver= new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://ecommerce.tealiumdemo.com/customer/account/login/";

        }

        [Then(@"Login for the Tealium")]
        public void ThenLoginForTheTealium()
        {
            driver.FindElement(By.XPath("(//input[contains(@class,'input-text required-entry')])[2]")).SendKeys("n@gmail.com");
            driver.FindElement(By.XPath("(//input[@class='input-text required-entry'])[2]")).SendKeys("1234567");
            Thread.Sleep(3000);
            var element = driver.FindElement(By.Id("send2"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            element.Submit();
            
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
