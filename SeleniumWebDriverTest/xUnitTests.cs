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
using Xunit;

namespace SeleniumWebDriverTest
{
    public class xUnitTests
    {
        string path = @".\";

        string name = "John Smith";
        string password = "12345";
        string country = "United States";
        string address = "Street number and name";
        string email = "john.smith@somewhere.tld";
        string phone = "+1 555 555 55";

        [Fact]
        public bool TestWithChromeDriver()
        {
            path = @"C:\Software\chromedriver_win32_76.0.3809.126";
            using (var driver = new ChromeDriver(path))
            {
                // Navigate to example page
                driver.Navigate().GoToUrl("https://example.testproject.io/web/");
                Thread.Sleep(500);

                // Enter username & password
                driver.FindElementById("name").SendKeys(name);
                Thread.Sleep(500);
                driver.FindElementById("password").SendKeys(password);
                Thread.Sleep(500);

                // Click login
                driver.FindElementById("login").Click();

                // Input new profile pages
                Thread.Sleep(500);
                new SelectElement(driver.FindElementById("country")).SelectByText(country);
                Thread.Sleep(500);
                driver.FindElementById("address").SendKeys(address);
                Thread.Sleep(500);
                driver.FindElementById("email").SendKeys(email);
                Thread.Sleep(500);
                driver.FindElementById("phone").SendKeys(phone);
                Thread.Sleep(500);
                // Update the profile
                driver.FindElementById("save").Click();

                return new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => d.FindElement(By.Id("saved")).Displayed);

            }
        }

        [Fact]
        public bool TestWithEdgeDriver()
        {
            path = @"C:\Windows\System32";
            using (var driver = new EdgeDriver(path))
            {
                // Navigate to example page
                driver.Navigate().GoToUrl("https://example.testproject.io/web/");

                Thread.Sleep(500);

                // Enter username & password
                driver.FindElementById("name").SendKeys(name);
                Thread.Sleep(500);
                driver.FindElementById("password").SendKeys(password);
                Thread.Sleep(500);

                // Click login
                driver.FindElementById("login").Click();

                Thread.Sleep(500);
                // Input new profile pages
                new SelectElement(driver.FindElementById("country")).SelectByText(country);
                Thread.Sleep(500);
                driver.FindElementById("address").SendKeys(address);
                Thread.Sleep(500);
                driver.FindElementById("email").SendKeys(email);
                Thread.Sleep(500);
                driver.FindElementById("phone").SendKeys(phone);
                Thread.Sleep(500);

                // Update the profile
                driver.FindElementById("save").Click();

                return new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => d.FindElement(By.Id("saved")).Displayed);
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
