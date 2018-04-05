using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Pool_5
{
    [TestFixture(Author ="Igor Vantukh")]
    public class VantukhTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            // driver = new InternetExplorerDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
        }

        [TestCase("usertask1@gmail.com", "usertest12345", "user test", Description ="Data for sign in")]
      //[TestCase("usertask2@gmail.com", "usertest", "user test", Description = "Data for sign in")] //нужно уточнить пароль
        public void SignIn_Using_GooglePlusAccount(string email, string password, string username)
        {
            LoginPage lp = new LoginPage();
         
            driver.Url = UsefullMethods.OpenTytbySite;
            driver.FindElement(By.XPath(lp.OpenLoginWindow)).Click();
            driver.FindElement(By.XPath(lp.OpenGooglePlus)).Click();
            driver.FindElement(By.XPath(lp.GoogleInputEmail)).SendKeys(email);
            driver.FindElement(By.XPath(lp.SubmitNextToPassword)).Click();
            
            driver.FindElement(By.XPath(lp.GoogleInputPassword)).SendKeys(password);
            driver.FindElement(By.XPath(lp.SubmitPassword)).Click();
            IWebElement UserName= wait.Until(ExpectedConditions.ElementExists(By.XPath(lp.UserNameInLoginWindow)));
            StringAssert.AreEqualIgnoringCase(username,UserName.Text,"Ошибка входа на сайт");

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
