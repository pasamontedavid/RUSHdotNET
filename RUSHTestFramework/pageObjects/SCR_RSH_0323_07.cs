using OpenQA.Selenium;
using RUSHTestFramework.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class SCR_RSH_0323_07:BaseConfig
    {
        String labelloc = "tblEntryHdr_";
        private IWebDriver driver;
        public SCR_RSH_0323_07(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //PARTICULAR LABEL
        [FindsBy(How = How.Id, Using = "tblEntryHdr_PART_CD")]
        private IWebElement Particularlabel;
        public IWebElement gotoParticularsLabel()
        {

            return Particularlabel;
        }
        //Particular Field Actual Values
        [FindsBy(How = How.Id, Using = "PART_CD")]
        private IWebElement Particular;
        public IWebElement gotoParticularsInput()
        {

            return Particular;
        }
        //Particular Field Expected Values
        public String[] ExpectedParticulars()
        {
            String[] Particulars = { "ADMIN REQUEST - TRANSFER OF ASSET/ASSET MOVEMENT/ASSET WAREHOUSING" };
            Array.Sort(Particulars);
            return Particulars;
        }

        //DateCreated
        [FindsBy(How = How.Id, Using = "REQD_DT")]
        private IWebElement DateCreated;
        public IWebElement gotoDateCreated()
        {

            return DateCreated;
        }


        [FindsBy(How = How.Id, Using = "TYP_ITEM")]
        private IWebElement TypeItem;
        public IWebElement gotoTypeItem()
        {

            return TypeItem;
        }

        [FindsBy(How = How.Id, Using = "CURR_LOC")]
        private IWebElement CurrentLoca;
        public IWebElement gotoCurrentLoca()
        {

            return CurrentLoca;
        }

        [FindsBy(How = How.Id, Using = "NEW_LOC")]
        private IWebElement NewLoca;
        public IWebElement gotoNewLoca()
        {

            return NewLoca;
        }


        [FindsBy(How = How.Id, Using = "DAT_REQ")]
        private IWebElement DateRequired;
        public IWebElement gotoDateRequired()
        {

            return DateRequired;
        }



        [FindsBy(How = How.Id, Using = "REAS_TRANS")]
        private IWebElement ReasonTransfer;
        public IWebElement gotoReasonTransfer()
        {

            return ReasonTransfer;
        }


        [FindsBy(How = How.Id, Using = "USER_ITEM")]
        private IWebElement UserItem;
        public IWebElement gotoUserItem()
        {

            return UserItem;
        }



        [FindsBy(How = How.Id, Using = "TAG_NUM")]
        private IWebElement TagNum;
        public IWebElement gotoTagNum()
        {

            return TagNum;
        }


        [FindsBy(How = How.Id, Using = "RMK")]
        private IWebElement Notes;
        public IWebElement gotoNotes()
        {

            return Notes;
        }

        //Activity 1
        public String ExpActivity1_Desc()
        {
            String expected = "Schedule of Service Requested";
            return expected;
        }

        public String ExpActivity1_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity1_Assignee()
        {
            String expected = "YULO, HENRY";
            return expected;
        }


        //Activity 2
        public String ExpActivity2_Desc()
        {
            String expected = "Confirm Schedule";
            return expected;
        }

        public String ExpActivity2_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity2_Assignee()
        {
            String expected = "ADMIN, IT";
            return expected;
        }


        //Activity 3
        public String ExpActivity3_Desc()
        {
            String expected = "Performance of Requested Service: Transfer/Move/Warehousing of Asset";
            return expected;
        }

        public String ExpActivity3_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity3_Assignee()
        {
            String expected = "DELA SANTA, RODEL";
            return expected;
        }



        //Activity 4
        public String ExpActivity4_Desc()
        {
            String expected = "Confirmation of completion of Requested Service";
            return expected;
        }

        public String ExpActivity4_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity4_Assignee()
        {
            String expected = "ADMIN, IT";
            return expected;
        }


        //Activity 5
        public String ExpActivity5_Desc()
        {
            String expected = "Updating of Inventory Record and attached Accountability";
            return expected;
        }

        public String ExpActivity5_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity5_Assignee()
        {
            String expected = "YULO, HENRY";
            return expected;
        }


        //Activity 6
        public String ExpActivity6_Desc()
        {
            String expected = "Acknowledged and attached signed accountability form";
            return expected;
        }

        public String ExpActivity6_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity6_Assignee()
        {
            String expected = "ADMIN, IT";
            return expected;
        }

        //Activity 7
        public String ExpActivity7_Desc()
        {
            String expected = "Rate the service rendered by Admin. Write VERY SATISFIED, SATISFIED, DISSATISFIED";
            return expected;
        }

        public String ExpActivity7_TAT()
        {
            String expected = "Days: 0\r\nHours: 4\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity7_Assignee()
        {
            String expected = "ADMIN, IT";
            return expected;
        }


        //Activity 8
        public String ExpActivity8_Desc()
        {
            String expected = "Justifiy the Rating and Recommendation";
            return expected;
        }

        public String ExpActivity8_TAT()
        {
            String expected = "Days: 0\r\nHours: 4\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity8_Assignee()
        {
            String expected = "ADMIN, IT";
            return expected;
        }

        //Activity 9
        public String ExpActivity9_Desc()
        {
            String expected = "Recording of Rating and Feedback";
            return expected;
        }

        public String ExpActivity9_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity9_Assignee()
        {
            String expected = "MAJUELO, KARLA";
            return expected;
        }

        //Activity 10
        public String ExpActivity10_Desc()
        {
            String expected = "Closing of Ticket";
            return expected;
        }

        public String ExpActivity10_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        public String ExpActivity10_Assignee()
        {
            String expected = "MAJUELO, KARLA";
            return expected;
        }





        //FORM DETAILS


    }


}
