using Myfirstrepository.Pages;
using Myfirstrepository.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstrepository.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employees_Tests : CommonDriver 
    {
        [SetUp]

        public void LoginSteps()
        {
            driver = new ChromeDriver("E:/Myfirstrepository");

            // Login page object initialization and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization and defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);
        }

        [Test, Order(1)]
        public void CreateEmployeeTest()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]

        public void EditEmployeeTest()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]

        public void DeleteEmployeeTest()
        {
            EmployeePage employeePageObl = new EmployeePage();
            employeePageObl.DeleteEmployee(driver);
        }

        [TearDown]

        public void ClosingSteps()
        {
            DriverCommand.Quit();
        }


    }
}
