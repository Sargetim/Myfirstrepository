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
        // Page objects initialization
        EmployeePage employeePageObj = new EmployeePage();
        HomePage homePageObj = new HomePage();
  

        [Test, Order(1)]
        public void CreateEmployeeTest()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]

        public void EditEmployeeTest()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]

        public void DeleteEmployeeTest()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
    }
}
