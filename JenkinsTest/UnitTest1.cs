using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JenkinsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GoogleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(@"https://google.com");
            Thread.Sleep(5000);
        }
    }
}
