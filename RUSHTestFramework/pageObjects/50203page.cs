using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class _50203page
    {
        private IWebDriver driver;
        public _50203page(IWebDriver driver)
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

        //Date_Created
        [FindsBy(How = How.Id, Using = "REQD_DT")]
        private IWebElement Date_Created;
        public IWebElement GotoDate_Created()
        {
            return Date_Created;
        }

        //Request_Category
        [FindsBy(How = How.Id, Using = "FLD_042301_REQST_CAT")]
        private IWebElement Request_Category;
        public IWebElement GotoRequest_Category()
        {
            return Request_Category;
        }

        //Expense_Category
        [FindsBy(How = How.Id, Using = "FLD_042301_EXPNSE")]
        private IWebElement Expense_Category;
        public IWebElement GotoExpense_Category()
        {
            return Expense_Category;
        }

        //Company
        [FindsBy(How = How.Id, Using = "FLD_042301_COMP")]
        private IWebElement Company;
        public IWebElement GotoCompany()
        {
            return Company;
        }

        //Cost_Center
        [FindsBy(How = How.Id, Using = "FLD_042301_CC")]
        private IWebElement Cost_Center;
        public IWebElement GotoCost_Center()
        {
            return Cost_Center;
        }

        //Group_Category
        [FindsBy(How = How.Id, Using = "FLD_TARGET_ACC")]
        private IWebElement Group_Category;
        public IWebElement GotoGroup_Category()
        {
            return Group_Category;
        }

        //Transaction_Type
        [FindsBy(How = How.Id, Using = "FLD_042301_TRNSCT")]
        private IWebElement Transaction_Type;
        public IWebElement GotoTransaction_Type()
        {
            return Transaction_Type;
        }

        //CA_Request
        [FindsBy(How = How.Id, Using = "FLD_042301_CA")]
        private IWebElement CA_Request;
        public IWebElement GotoCA_Request()
        {
            return CA_Request;
        }

        //Transaction_Date
        [FindsBy(How = How.Id, Using = "FLD_042301_TR_DT")]
        private IWebElement Transaction_Date;
        public IWebElement GotoTransaction_Date()
        {
            return Transaction_Date;
        }

        //Invoice
        [FindsBy(How = How.Id, Using = "FLD_042301_IVSOBS")]
        private IWebElement Invoice;
        public IWebElement GotoInvoice()
        {
            return Invoice;
        }

        //Document_Date
        [FindsBy(How = How.Id, Using = "FLD_042301_DOCDT")]
        private IWebElement Document_Date;
        public IWebElement GotoDocument_Date()
        {
            return Document_Date;
        }

        //Date_Received
        [FindsBy(How = How.Id, Using = "FLD_042301_DTREC")]
        private IWebElement Date_Received;
        public IWebElement GotoDate_Received()
        {
            return Date_Received;
        }

        //Payee_Name
        [FindsBy(How = How.Id, Using = "FLD_042301_PAYNAM")]
        private IWebElement Payee_Name;
        public IWebElement GotoPayee_Name()
        {
            return Payee_Name;
        }

        //Gross_Amount
        [FindsBy(How = How.Id, Using = "FLD_042301_GROSS")]
        private IWebElement Gross_Amount;
        public IWebElement GotoGross_Amount()
        {
            return Gross_Amount;
        }

        //Date_required
        [FindsBy(How = How.Id, Using = "FLD_042301_DT_REQ")]
        private IWebElement Date_required;
        public IWebElement GotoDate_required()
        {
            return Date_required;
        }

        //External_Vendors_RFP
        [FindsBy(How = How.Id, Using = "FLD_042301_EX_RFP")]
        private IWebElement External_Vendors_RFP;
        public IWebElement GotoExternal_Vendors_RFP()
        {
            return External_Vendors_RFP;
        }

        //External_Vendors_email
        [FindsBy(How = How.Id, Using = "FLD_042301_EXEMAIL")]
        private IWebElement External_Vendors_email;
        public IWebElement GotoExternal_Vendors_email()
        {
            return External_Vendors_email;
        }

        // Notesfield
        [FindsBy(How = How.Id, Using = "RMK")]
        private IWebElement Notesfield;
        public IWebElement GotoNotesfield()
        {
            return Notesfield;
        }

    }
}
