using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TealiumSpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        public FeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            /*
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Manage().Window.Maximize();
            */
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://ecommerce.tealiumdemo.com/";

        }

        [Then(@"Login for the Tealium")]
        public void ThenLoginForTheTealium()
        {
            driver.FindElement(By.XPath("(//span[@class='label'])[3]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Log In')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("(//input[contains(@class,'input-text required-entry')])[2]")).SendKeys("n@gmail.com");
            driver.FindElement(By.XPath("(//input[@class='input-text required-entry'])[2]")).SendKeys("1234567");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//span[text()='Login']")).Submit();
            Thread.Sleep(3000);
            //driver.Close();

        }
    }
}
