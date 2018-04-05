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

    public class testChepil
    {
        private IWebDriver driver;
        private WebDriverWait wait;

      //  SETUP
        public void SetUp() {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            //driver = new InternetExplorerDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            string url = "https://www.tut.by/";
        }
        //TestCase(Description = "find element 'Разделы' on the page")
        public void findElementOnThePage()
        {
            MainPage mp = new MainPage();
            driver.Url = mp.url;
            driver.FindElement(By.XPath(mp.headerResourses)).Click();
            IWebElement news = wait.Until(ExpectedConditions.ElementExists(By.XPath(mp.resoursesNews)));
            driver.FindElement(By.XPath(mp.resoursesNews)).Click();
        }
    }
}