using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;

namespace AutoTest
{
    class ChromeTest
    {
        IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver("D:\\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void Test()
        {
            driver.Url = "https://www.google.com/";
            IWebElement element = driver.FindElement(By.Name("q"));
            element.Click();
            element.SendKeys("автотесты");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            element = driver.FindElement(By.XPath("//*[@id='rso']/div/div/div[3]/div/div/h3/a"));
            element.Click();
            element = driver.FindElement(By.XPath("//*[@id='push']/header/h1"));
            Assert.That(element.Text, Is.SamePath("Как писать автотесты быстро"));
        }

        [TearDown]

        public void Close()
        {
            driver.Close();
        }
    }
}
