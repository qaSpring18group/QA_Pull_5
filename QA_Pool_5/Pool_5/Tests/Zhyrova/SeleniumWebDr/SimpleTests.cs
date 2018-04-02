using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace SimpleTests
{
    [TestFixture]
    public class SimpleTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
             driver = new ChromeDriver();
            //driver = new FirefoxDriver();
           // driver = new InternetExplorerDriver();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
           
          
        }

        [Test(Description ="simple test check")]
        public void QA_Homework_Test()
        {
            driver.Url = "https://www.google.com.ua/";
            driver.FindElement(By.XPath("//input[@id='lst-ib']")).SendKeys("автотесты" + Keys.Enter);
            driver.FindElement(By.PartialLinkText("Заметки Автоматизатора")).Click();
            IWebElement posttitle = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='post-title']")));
            string str = posttitle.Text;
            StringAssert.AreEqualIgnoringCase("Как писать автотесты быстро", posttitle.Text,"Ошибка текста");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
