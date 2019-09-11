using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverTest
{
    [TestClass]
    public class MsTests
    {
        //var text = "TFS Test API";
        //var text = "TEST FRAMEWORK";
        string text = "AUTHOR";

        [TestMethod]
        public void TestWithChromeDriver()
        {
            //var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = @"C:\Software\chromedriver_win32_76.0.3809.126";
            using (var driver = new ChromeDriver(path))
            {
                driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
                var link = driver.FindElement(By.PartialLinkText(text));
                Thread.Sleep(500);
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText(text)));
                clickableElement.Click();
                Thread.Sleep(500);
            }
        }

        [TestMethod]
        public void TestWithEdgeDriver()
        {
            var path = @"C:\Windows\System32";
            //using (var driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            using (var driver = new EdgeDriver(path))
            {
                driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
                var link = driver.FindElement(By.PartialLinkText(text));
                Thread.Sleep(500);
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText(text)));
                clickableElement.Click();
                Thread.Sleep(2000);
            }
        }

        //[TestMethod]
        //public void TestWithFirefoxDriver()
        //{
        //    //using (var driver = new FirefoxDriver())
        //    using (var driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
        //    {
        //        Thread.Sleep(10000);
        //        driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
        //        var link = driver.FindElement(By.PartialLinkText("TFS Test API"));
        //        var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
        //        ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
        //        var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        //        var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("TFS Test API")));
        //        clickableElement.Click();
        //    }
        //}
    }
}
