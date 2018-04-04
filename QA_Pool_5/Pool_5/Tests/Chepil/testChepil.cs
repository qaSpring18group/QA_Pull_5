using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chepil
{

    class Program
    {
        static void Main(string[] args)
        {
           
            string resource = "//*[@id='mainmenu']/ul/li[1]/a/text()";
            string url = "https://www.tut.by";
            string compare = "Раздели";
            //selenium
            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath(resource)).Click();

        }

    }
}