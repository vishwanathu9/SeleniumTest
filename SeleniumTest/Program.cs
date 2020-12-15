using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

         static void Main(string[] args)
        {            
          
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Login=Login");
            Console.WriteLine("Opened url !");
        }
        [Test]
        public void ExecuteTest()
        {
            //Title 
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Executeutomation", "Id");
            SeleniumSetMethods.Click(driver, "Save", "Name");
            Console.WriteLine("Dropdown" + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));
            Console.WriteLine("TextBox" + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
