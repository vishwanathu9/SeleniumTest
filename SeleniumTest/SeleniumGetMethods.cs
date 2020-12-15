using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SeleniumTest
{
    class SeleniumGetMethods
    {
        public static string GetText( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropertiesColleciton.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropertiesColleciton.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;
        }
        public static string GetTextFromDDL( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return new SelectElement(PropertiesColleciton.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == PropertyType.Name)
                return new SelectElement(PropertiesColleciton.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }
    }
}
