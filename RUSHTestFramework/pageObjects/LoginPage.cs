using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver= driver;
            PageFactory.InitElements(driver, this);
        }


        //Page Objects

        //USERID/LoginID
        [FindsBy(How = How.Id, Using = "LoginID")]
        private IWebElement LoginID;
        public IWebElement gotoLoginID()
        {
            return LoginID;
        }


        //PASSWORD
        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement Password;
        public IWebElement gotoPassword()
        {
            return Password;
        }

        //Submit BUTTON

        [FindsBy(How = How.Id, Using = "cmdLogin")]
        private IWebElement Submit;
        public IWebElement gotoSubmit()
        {
            return Submit;
        }

       

    }
}
