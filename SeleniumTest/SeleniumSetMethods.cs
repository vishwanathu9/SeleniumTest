using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
    class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesColleciton.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesColleciton.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Clicks
        public static void Click( string element,PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesColleciton.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesColleciton.driver.FindElement(By.Name(element)).Click();
        }

        //Selecting the dropdown control
        public static void SelectDropDown( string element, string value, PropertyType elementType)
        {

            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesColleciton.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesColleciton.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
