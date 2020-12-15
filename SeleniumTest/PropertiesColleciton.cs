using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
    enum PropertyType
    {
        Id,
        Name,
        linkText

    }
    class PropertiesColleciton
    {
      
        public static IWebDriver driver { get; set; }
    }

}
