using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver webDriver = new ChromeDriver("D://");
            webDriver.Navigate().GoToUrl("https://www.google.com.ua");
            IWebElement element = webDriver.FindElement(By.Id("lst-ib"));
            element.SendKeys("автотесты\n");
            IWebElement saearchresult = webDriver.FindElement(By.LinkText("Как писать автотесты быстро - Заметки Автоматизатора"));
            saearchresult.Click();
            //НУЖНО ПРОВЕРИТЬ СОДЕРЖАНИЕ ТЕКСТА В КОНКРЕТНОМ ЭЛЕМЕНТЕ,  А НЕ НА СТРАНИЦЕ В ЦЕЛОМ
            IWebElement searchheader = webDriver.FindElement(By.XPath("//*[@id='push']/header/h1"));
            NUnit.Framework.Assert.IsTrue(searchheader.Text.Contains("Как писать автотесты быстро"), "The page doesn't contain the text 'Как писать автотесты быстро'");
            webDriver.Quit();
        }
    }
}
