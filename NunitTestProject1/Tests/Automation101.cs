using NunitTestProject1.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V119.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace NunitTestProject1.Tests
{

    // create a project
    // Add a package
    // Create object of Iweb driver
    // Use the varable of Iwebdriver to navigate to url
    // Manipulate the web page
    public class Automation101 : HooksPages
    {

        [Test]
        public void AutomationTest01()
        {





            //driverMethods.FindElement(By.Name("email")).SendKeys("kwam@test.com");
            //driverMethods.FindElement(By.Name("password")).SendKeys("kwam1234");
            //driverMethods.FindElement(By.CssSelector("[data-qa='login-button']")).Click();
            //driverMethods.FindElement(By.Name(""));


            // Assert.That(name.Equals("Kwam");


            
            //Browser.Navigate().GoToUrL("");

        }
        // create a method using Chrome options
        //public ChromeOptions MaximizeChromeBrowser()
        //{
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArguments("start-maximized", "incognito");
        //    return options;

        //}




    }
}
