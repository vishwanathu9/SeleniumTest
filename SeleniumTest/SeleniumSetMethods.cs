using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
   static class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Clicks
        public static void Clicks(this  IWebElement element)
        {
            element.Click();
        }

        //Selecting the dropdown control
        public static void SelectDropDown(this IWebElement element, string value)
        {           
                new SelectElement(element).SelectByText(value);
           
        }
    }
}
