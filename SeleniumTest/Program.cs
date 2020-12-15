﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Program
    {
       
         static void Main(string[] args)
        {            
          
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesColleciton.driver = new ChromeDriver();
            PropertiesColleciton.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Opened url !");
        }
        [Test]
        public void ExecuteTest()
        {

            //Login to App

            LoginPageObject Pagelogin = new LoginPageObject();
            EAPageObject pageEA = Pagelogin.Login("hello", "vishwanath");
            pageEA.FillUserForm("kk", "Karthik", "sngh");
           
            //pageEA.txtInitial.SendKeys("Hello vishwanath");
            //pageEA.btnSave.Click();
            ////Title 
            //SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);
            //SeleniumSetMethods.EnterText( "Initial", "Executeutomation", PropertyType.Id);
            //SeleniumSetMethods.Click( "Save", PropertyType.Name);
            //Console.WriteLine("Dropdown" + SeleniumGetMethods.GetTextFromDDL( "TitleId", PropertyType.Id));
            //Console.WriteLine("TextBox" + SeleniumGetMethods.GetText( "Initial", PropertyType.Name));

        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesColleciton.driver.Close();

        }
    }
}
