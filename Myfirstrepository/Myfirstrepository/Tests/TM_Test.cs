using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



// Open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

// Identify the username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// Identify the password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// Identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(1500);

// Check if user has successfully logged in
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully!");
}
else
{
    Console.WriteLine("Login failed!");
}

// Create a new Material record 
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

// Navigate to Time and Material page
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(1000);

// Click on Create New button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
Thread.Sleep(1000);


// Select Time option from TypeCode dropdown list
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typeCodeDropdown.Click();
Thread.Sleep(6000);

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

// input code into Code textbook
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("First Repository");

// Input descripton into Description box
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("First Repository");

// Input Price per unit into price per unit textbox
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("12345");

// Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

// Check if new Time record has been created
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();
Thread.Sleep(5000);

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(newCode.Text == "First Repository")
{
    Console.WriteLine("New Time reocrd created successfully");
}
else
{
    Console.WriteLine("Record hasn't been created");
}

// Click on edit button to edit record

IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();


// Enter new record in Price field

IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.Clear();
codeTextBox.SendKeys("MyFirstRepository1.0");

//Click on save button after editing record
IWebElement editsavebtn = driver.FindElement(By.Id("SaveButton"));
editsavebtn.Click();
Thread.Sleep(6000);



// Go to last page after editing record

IWebElement GoToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
GoToLastPage1.Click();
Thread.Sleep(5000);



IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (editedCode.Text == "MyFirstRepository1.0")
{
    Console.WriteLine("Record is edited successfully");
}
else
{
    Console.WriteLine("Record not Editted");
}

//Click on Delete button 
IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deletebtn.Click();
Thread.Sleep(6000);

// Click on OK button on popup box
IAlert al = driver.SwitchTo().Alert();
al.Accept();
Thread.Sleep(4000);


IWebElement deleterecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (deleterecord.Text == "First Repository 1.0")
{
    Console.WriteLine("Record has not been deleted successfully");
}
else
{
    Console.WriteLine("Record is deleted successfully");
}






