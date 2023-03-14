using Myfirstrepository.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstrepository.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]

        public void LoginSteps()
        {
            driver = new ChromeDriver("E:/Myfirstrepository");

            // Login page object initialization and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [TearDown]

        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}
