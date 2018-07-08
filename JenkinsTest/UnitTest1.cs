using System;
using System.Drawing.Imaging;
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
            Console.WriteLine("Test Case has been started");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(@"https://google.com");
            TakeScrenShot(driver);
            Thread.Sleep(2000);
            driver.Quit();
            Console.WriteLine("Test Case has been finished");

            throw new Exception("Test cases failed");
        }

        void TakeScrenShot(IWebDriver driver)
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("SeleniumTestingScreenshot.jpg", 
                    OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
