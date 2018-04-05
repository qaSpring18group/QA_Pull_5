using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace Pool_5 //.Tests.Ivchenko
{
    [TestFixture(Author = "Olena Ivchenko")]
    public class IvchenkoTest_FT_7M
    {
       
            private IWebDriver driver;
            private WebDriverWait wait;

            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                driver.Manage().Window.Maximize();
            }

            [TestCase]
            
            public void FT_7M ()
            {
                //this test in a developing process

            }


            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }


