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
    public class SCR_RSH_0323_06
    {
        private IWebDriver driver;
        public SCR_RSH_0323_06(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
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
            String[] Particulars = { "Admin Request - SPECIAL PERSONNEL SUPPORT" };
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

        //PERSONNEL/MANPOWER Type
        [FindsBy(How = How.Id, Using = "PER_MPT")]
        private IWebElement ManpowerType;
        public IWebElement gotoManpowerType()
        {

            return ManpowerType;
        }
        //PERSONNEL/MANPOWER Type Expected Values
        public String[] ExpectedManpower()
        {
            String[] Options = {  "Driver", "Helper", "Janitor","Messenger" };
            Array.Sort(Options);
            return Options; 
        }


        //Quantity/Number of Personnel Needed
        [FindsBy(How = How.Id, Using = "QTY")]
        private IWebElement QuantityNumberofPersonnel;
        public IWebElement gotoQuantityNumberofPersonnel()
        {
            return QuantityNumberofPersonnel;
        }

        //DateNeeded
        [FindsBy(How = How.Id, Using = "DAT_REQ")]
        private IWebElement DateNeeded;
        public IWebElement gotoDateNeeded()
        {

            return DateNeeded;
        }

        //TimeFrom
        [FindsBy(How = How.Id, Using = "TIME_FR")]
        private IWebElement TimeFrom;
        public IWebElement gotoTimeFrom()
        {

            return TimeFrom;
        }

        //TimeTo
        [FindsBy(How = How.Id, Using = "TIME_TO")]
        private IWebElement TimeTo;
        public IWebElement gotoTimeTo()
        {
            return TimeTo;
        }

        //Details of Activity Required (Service Needed, Location, Project, Etc)
        [FindsBy(How = How.Id, Using = "DET_ACT")]
        private IWebElement DetailsRquired;
        public IWebElement gotoDetailsRquired()
        {

            return DetailsRquired;
        }


        //Notes
        [FindsBy(How = How.Id, Using = "RMK")]
        private IWebElement Notes;
        public IWebElement gotoNotes()
        {
            return Notes;
        }



    }
}
