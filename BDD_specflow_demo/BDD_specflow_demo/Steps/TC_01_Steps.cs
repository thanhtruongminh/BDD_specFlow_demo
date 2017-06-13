using BDD_specflow_demo.UIs;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace BDD_specflow_demo
{
    [Binding]
    public class TC_01_Steps
    {
        IWebDriver driver;

        [Given(@"I am on LiveGuru99 site")]
        public void GivenIAmOnLiveGuruSite()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver(@"E:\programming\C#\BDD\BDD_specflow_demo\BDD_specflow_demo\Drivers");
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(MyAccountUI.MY_ACCOUNT_URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }

        [Given(@"I input username ""(.*)"" and password ""(.*)""")]
        public void GivenIInputUsernameAndPassword(string username, string password)
        {
            driver.FindElement(By.XPath(MyAccountUI.USERNAME_TXT)).SendKeys(username);
            driver.FindElement(By.XPath(MyAccountUI.PASSWORD_TXT)).SendKeys(password);
        }

        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            driver.FindElement(By.XPath(MyAccountUI.LOGIN_BTN)).Click();
        }

        [Then(@"The error message should be display")]
        public Boolean ThenTheErrorMessageShouldBeDisplay()
        {
            IWebElement error_msg = driver.FindElement(By.XPath(MyAccountUI.INVALID_ERROR_MSG));
            return error_msg.Displayed;

        }
        [After]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
