using Myfirstrepository.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// Open Chrome Browser
IWebDriver driver = new ChromeDriver("E:/Myfirstrepository");

// Login page object initialization and defination
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

// Home page object initialization and defination
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM page object initialization and defination
TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

// Edit TM
tmPageObj.EditTM(driver);

// Delete
tmPageObj.DeleteTM(driver);













