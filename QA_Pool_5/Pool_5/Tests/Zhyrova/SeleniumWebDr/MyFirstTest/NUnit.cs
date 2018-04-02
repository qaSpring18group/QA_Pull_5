using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyFirstTest
{
    class NUnit
    {
        IWebDriver webDriwer;
        [SetUp]
        public void IB()
        {
            webDriwer = new ChromeDriver();
        }
        [Test]
        public void TestNunit()

        {
            webDriwer.Navigate().GoToUrl("https://www.google.com.ua");
            //  var lnkSupportUs=webDriwer.FindElement(By.CssSelector(""))
            webDriwer.Manage().Window.Maximize();
            webDriwer.FindElement(By.Id("lst-ib")).SendKeys("Автотесты");
            webDriwer.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            webDriwer.FindElement(By.LinkText("Как писать автотесты быстро - Заметки Автоматизатора")).SendKeys(Keys.Enter);
            webDriwer.FindElement(By.Id("push"));
            Console.WriteLine("Element found");

        }
        [TearDown]
        public void CloseBr()
        {
            webDriwer.Close();
        }
    }
}
