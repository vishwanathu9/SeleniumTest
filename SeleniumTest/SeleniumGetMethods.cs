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
        public static string GetText( IWebElement element)
        {
            return element.GetAttribute("value");
         
        }
        public static string GetTextFromDDL( IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
