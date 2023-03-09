using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstrepository.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
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
            descriptionTextbox.SendKeys("First Repo");

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
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            Assert.That(newCode.Text == "First Repository", "Actual code and expected code do not match. ");
            Assert.That(newDescription.Text == "First Repo", "Actual description and expected description do not match. ");

            //if (newCode.Text == "First Repository")
            //{
            //    Assert.Pass("New Time record created successfully!");
            //}
            //else
            //{
            //    Assert.Fail("Record hasn't been created");
            //}
        }

        public void EditTM(IWebDriver driver)
        {
            // Click on edit button to edit record

            Thread.Sleep(1000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement recordToBeEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordToBeEdited.Text == "First Repository")
            {
                IWebElement lastRecordEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                lastRecordEdit.Click();
            }
            else 
            {
                Assert.Fail("Record to be edited not found");
            }
               
                 
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
        }



        public void DeleteTM(IWebDriver driver)
        {

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            IWebElement recordToBeDeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordToBeDeleted.Text == "MyFirstRepository1.0")
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                deleteButton.Click();   
            }
            else
            {
                Assert.Fail("Record to be deleted not found. ");
            }

            //Click on Delete button 
            IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebtn.Click();
            Thread.Sleep(6000);

            // Click on OK button on popup box
            driver.SwitchTo().Alert().Accept();

            IWebElement deleterecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            Assert.That(deleterecord.Text != "First Repository 1.0", "Record hasn't been deleted");


            //if (deleterecord.Text == "First Repository 1.0")
            //{
            //    Console.WriteLine("Record has not been deleted successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Record is deleted successfully");
            //}
        }
    }
}

    

    
       
         