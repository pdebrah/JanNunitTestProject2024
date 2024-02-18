using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitTestProject1.ObjectRepository;

namespace NunitTestProject1.Hooks
{
    public  class HooksPages : MyObjects
    {
        [SetUp] 
        public void Setup()
        {
            driver = new ChromeDriver(new CustomerMethods().MaximizeChromeBrowser());
            //driver.Navigate().GoToUrl("https://demoqa.com/login");
            //driver.Manage().Window.Maximize(); // You can also use this method to maximum  web page
            //Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://automationexercise.com/login");
            //Thread.Sleep(1000);

        }

        [TearDown]          
         public void TearDown()
        {
            if (driverMethods != null)
            {
                driverMethods.Quit();

            }
            driverMethods = null;
        }
    }
}
