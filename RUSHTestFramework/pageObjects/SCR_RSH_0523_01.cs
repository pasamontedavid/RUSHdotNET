using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class SCR_RSH_0523_01
    {

        private IWebDriver driver;
        public SCR_RSH_0523_01(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Particular
        [FindsBy(How = How.Id, Using = "PART_CD")]
        private IWebElement Particular;
        public IWebElement GotoParticular()
        {
            return Particular;
        }

        //RequestDate
        [FindsBy(How = How.Id, Using = "REQD_DT")]
        private IWebElement RequestDate;
        public IWebElement GotoRequestDate()
        {
            return RequestDate;
        }

        //NatureOfService
        [FindsBy(How = How.Id, Using = "FLD_052301_NA_SRV")]
        private IWebElement NatureOfService;
        public IWebElement GotoNatureOfService()
        {
            return NatureOfService;
        }

        //DateRequired
        [FindsBy(How = How.Id, Using = "FLD_052301_DT_REQ")]
        private IWebElement DateRequired;
        public IWebElement GotoDateRequired()
        {
            return DateRequired;
        }

        //Quantity
        [FindsBy(How = How.Id, Using = "FLD_052301_QTY")]
        private IWebElement Quantity;
        public IWebElement GotoQuantity()
        {
            return Quantity;
        }

        //UnitMeasure
        [FindsBy(How = How.Id, Using = "FLD_052301_UNIT")]
        private IWebElement UnitMeasure;
        public IWebElement GotoUnitMeasure()
        {
            return UnitMeasure;
        }

        //UsageForThePeriodFrom
        [FindsBy(How = How.Id, Using = "FLD_052301_U_FRM")]
        private IWebElement UsageForThePeriodFrom;
        public IWebElement GotoUsageForThePeriodFrom()
        {
            return UsageForThePeriodFrom;
        }

        //UsageForThePeriodTo
        [FindsBy(How = How.Id, Using = "FLD_052301_U_TO")]
        private IWebElement UsageForThePeriodTo;
        public IWebElement GotoUsageForThePeriodTo()
        {
            return UsageForThePeriodTo;
        }

        //DateLastRequested
        [FindsBy(How = How.Id, Using = "FLD_052301_LAST_REQ")]
        private IWebElement DateLastRequested;
        public IWebElement GotoDateLastRequested()
        {
            return DateLastRequested;
        }

        //CurrentStock
        [FindsBy(How = How.Id, Using = "FLD_052301_STOCK")]
        private IWebElement CurrentStock;
        public IWebElement GotoCurrentStock()
        {
            return CurrentStock;
        }


    }
}
