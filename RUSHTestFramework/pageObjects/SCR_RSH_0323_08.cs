using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class SCR_RSH_0323_08
    {
        private IWebDriver driver;
        public SCR_RSH_0323_08(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Activity 1
        public String ExpActivity1_Desc()
        {
            String expected = "Processes approved RFP and prepares APV";
            return expected;
        }

        public String ExpActivity1_TAT()
        {
            String expected = "Days: 2\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        //Activity 2
        public String ExpActivity2_Desc()
        {
            String expected = "Check and approves rejects APV";
            return expected;
        }

        public String ExpActivity2_TAT()
        {
            String expected = "Days: 2\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }



        //Activity 3
        public String ExpActivity3_Desc()
        {
            String expected = "Receives APV and prepares check";
            return expected;
        }

        public String ExpActivity3_TAT()
        {
            String expected = "Days: 2\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }

        //Activity 4
        public String ExpActivity4_Desc()
        {
            String expected = "outing and approval of Check";
            return expected;
        }

        public String ExpActivity4_TAT()
        {
            String expected = "Days: 2\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        //Activity 5
        public String ExpActivity5_Desc()
        {
            String expected = "Pick-up by Treasury Associate of checks for release";
            return expected;
        }

        public String ExpActivity5_TAT()
        {
            String expected = "Days: 1\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        //Activity 6
        public String ExpActivity6_Desc()
        {
            String expected = "Document & Compliance Checking. (Scanning of APV and supporting documents in FLI Cebu office. Transmission to FLI Head Office every month end of hardcopies)";
            return expected;
        }

        public String ExpActivity6_TAT()
        {
            String expected = "Days: 30\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


        //Activity 7
        public String ExpActivity7_Desc()
        {
            String expected = "Receives feedback and closes the ticket";
            return expected;
        }

        public String ExpActivity7_TAT()
        {
            String expected = "Days: 30\r\nHours: 0\r\nMinutes: 0";
            return expected;
        }


    }
}
