using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class MyRequestsPage
    {
        private IWebDriver driver;

        public MyRequestsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //My Request
        [FindsBy(How=How.Id, Using = "e0_0i")]
        private IWebElement Myrequest;

        public IWebElement gotoMyrequest()
        {
            return Myrequest;
        }

        //My Requests
        [FindsBy(How = How.Id, Using = "e0_2i")]
        private IWebElement Myrequests;

        public IWebElement gotoMyrequests()
        {
            return Myrequests;
        }

        //My Work Queue
        [FindsBy(How = How.Id, Using = "e0_3i")]
        private IWebElement MyWorkQueue;

        public IWebElement gotoMyworkqueue()
        {
            return MyWorkQueue;
        }

        //Work Queue
        [FindsBy(How = How.Id, Using = "e0_5i")]
        private IWebElement Workqueue;

        public IWebElement gotoWorkqueue()
        {
            return Workqueue;
        }


        //Landing Page URL of My Requests Page
        public String MyrequestsLandingPage()
        {
            String ExpectedURL = "http://rush.sit.federalland.ph/RUSH_SIT/REQSTQUEUE/MYREQUESTS.aspx";
            return ExpectedURL;
        }

        //Categories
        [FindsBy(How = How.Id, Using = "drpReqstCateg")]
        private IWebElement RequestCategory;

        public IWebElement gotoRequestCategory()
        {
            return RequestCategory;
        }


        //Request TYpe
        [FindsBy(How = How.Id, Using = "drpReqstCodes")]
        private IWebElement RequestType;

        public IWebElement gotoRequestType()
        {
            return RequestType;
        }


        //Confirm/Submit
        [FindsBy(How = How.Id, Using = "cmdAdd")]
        private IWebElement Confirm;

        public IWebElement gotoConfirm()
        {
            return Confirm;
        }


        public String RequestLandingPage(string reqcode)
        {
            String ExpectedURL = "http://rush.sit.federalland.ph/RUSH_SIT/REQSTQUEUE/Request.aspx?REQST_CD="+reqcode;
            return ExpectedURL;
        }

        //Get Request Number
        [FindsBy(How = How.CssSelector, Using = ".MainTableRow:nth-child(2) > td:nth-child(2)")]
        private IWebElement RequestnoLocator;
        public IWebElement gotoRequestnoLocator()
        {
            return RequestnoLocator;
        }

    }
}
