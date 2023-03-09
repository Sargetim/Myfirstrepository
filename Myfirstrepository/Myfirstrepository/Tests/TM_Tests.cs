using Myfirstrepository.Pages;
using Myfirstrepository.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace Myfirstrepository.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver 
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
            homePageObj.GoToTMPage(driver);
        }
        
        [Test, Order(1), Description("Chcek if user is able to create Time record with valid data")]
        public void CreateTMTest()
        {
            // TM page object initialization and defination
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an existing record with valid data")]
        public void EditTMTest()
        {
            // TM page object initialization and defination
            TMPage tmPageObj = new TMPage();
            // Edit TM
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete an existing Time record")]
        public void DeleteTMTest()
        {
            // TM page object initialization and defination
            TMPage tmPageObj = new TMPage();
            // Delete
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTMTest()
        {
            driver.Quit();
        }
    }
}
