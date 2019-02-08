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
using System.Threading.Tasks;
using Xunit;

namespace SeleniumWebDriverTest
{   
    public class xUnitTests
    {
        string path = "D:\\Temp\\GitTest\\SeleniumSample\\SeleniumWebDriverTest\\bin\\Debug";

        [Fact]
        public void TestWithChromeDriver()
        {

            using (var driver = new ChromeDriver(path))
            {
                driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
                var link = driver.FindElement(By.PartialLinkText("TFS Test API"));
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("TFS Test API")));
                clickableElement.Click();
            }
        }

        [Fact]
        public void TestWithEdgeDriver()
        {
            using (var driver = new EdgeDriver(path))
            {
                driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
                var link = driver.FindElement(By.PartialLinkText("TFS Test API"));
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("TFS Test API")));
                clickableElement.Click();
            }
        }

        //[Fact]
        //public void TestWithFirefoxDriver()
        //{
        //    using (var driver = new FirefoxDriver(path))
        //    {
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
