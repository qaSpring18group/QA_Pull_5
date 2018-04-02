using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriwer = new ChromeDriver();
            webDriwer.Url= "https://www.google.com.ua";
            webDriwer.Manage().Window.Maximize();
            webDriwer.FindElement(By.Id("lst-ib")).SendKeys("Автотесты");
            webDriwer.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            webDriwer.FindElement(By.LinkText("Как писать автотесты быстро - Заметки Автоматизатора")).SendKeys(Keys.Enter);
            webDriwer.FindElement(By.Id("push"));
            Console.WriteLine("Element found");

            webDriwer.Quit();

            

        }
    }
}
