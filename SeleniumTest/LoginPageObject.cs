using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesColleciton.driver, this);
        }
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string UserName,string Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            btnLogin.Submit();
            return new EAPageObject();
        }
    }
}
