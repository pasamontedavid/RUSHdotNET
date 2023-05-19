using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class HR_LV_DEP_HD
    {
        private IWebDriver driver;
        public HR_LV_DEP_HD(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Expected Approver
        public String[] ExpectedApprover()
        {
            String[] Approvers = { "BOKINGKITO, JERNON " };
            return Approvers;
        }

        public String[] ExpectedActivity1ClusterMem()
        {
            String[] ClusterMem = { "FERMATO, JHOAN TAMILAG", "OPERARIO, THOMAS LEMUEL O" };
            return ClusterMem;
        }

        //Expected Description
        public String[] ExpectedDescription()
        {
            String[] Description = { "ENDORSED BY", "ENDORSED BY" };
            return Description;
        }


        //Particular Field Actual Values
        [FindsBy(How = How.Id, Using = "PART_CD")]
        private IWebElement Particular;
        public IWebElement gotoParticulars()
        {

            return Particular;
        }
        //Particular Field Expected Values
        public String[] ExpectedParticulars()
        {
            String[] Particulars = { "EMERGENCY LEAVE", "MATERNITY LEAVE", "PATERNITY LEAVE", "SICK LEAVE", "SOLO PARENT LEAVE", "SPECIAL LEAVE FOR WOMEN", "UNDERTIME", "VACATION LEAVE" };
            Array.Sort(Particulars);
            return Particulars;
        }
        

        //DateCreated
         [FindsBy(How = How.Id, Using = "REQD_DT")]
        private IWebElement Requestdate;
        public IWebElement gotoRequestdate()
        {

            return Requestdate;
        }

        //certify Actual Values
        [FindsBy(How = How.Id, Using = "HR_LV_CERT")]
        private IWebElement Certify;
        public IWebElement gotoCertify()
        {

            return Certify;
        }
        //certify Expected Values
        public String[] ExpectedCertify()
        {
            String[] Options = {  "Yes" };
            Array.Sort(Options);
            return Options;
        }


        //Balancefield
        [FindsBy(How = How.Id, Using = "BAL")]
        private IWebElement Balfield;
        public IWebElement gotoBalfield()
        {
            return Balfield;
        }

        //LeaveFrom
        [FindsBy(How = How.Id, Using = "LV_FR")]
        private IWebElement Leavefrom;
        public IWebElement gotoLeavefrom()
        {

            return Leavefrom;
        }

        //LeaveTo
        [FindsBy(How = How.Id, Using = "LV_TO")]
        private IWebElement Leaveto;
        public IWebElement gotoLeaveto()
        {

            return Leaveto;
        }

        //NumberOfDays
        [FindsBy(How = How.Id, Using = "NUM_DAYS")]
        private IWebElement NumberOfDays;
        public IWebElement gotoNumberOfDays()
        {
            return NumberOfDays;
        }

        //DateOfReturn
        [FindsBy(How = How.Id, Using = "DT_OF_RET")]
        private IWebElement DateOfReturn;
        public IWebElement gotoDateOfReturn()
        {

            return DateOfReturn;
        }


        //Reasons
        [FindsBy(How = How.Id, Using = "RES")]
        private IWebElement Reasons;
        public IWebElement gotoReasons()
        {
            return Reasons;
        }



    }
}
