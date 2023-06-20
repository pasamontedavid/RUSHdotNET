using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RUSHTestFramework.pageObjects;
using RUSHTestFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.SCR
{
    public class _50203:BaseConfig
    {
        String RequestNo= "23142798823";
        public void ApprovalDept(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JB201582", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void ApprovalDiv(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("PV211633", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void ApprovalGMPres(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("TM191424", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void ApprovalBLRDC(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("GD221871", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void ApprovalLG(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("ES211669", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }
        
         public void ApprovalPPD(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("RB232095", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void Activity1(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JM211673", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Processes approved RFP and prepares APV");
            ActivityApprovemod();
        }
        

        public void Activity1Construction(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("RD161107", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Processes approved RFP and prepares APV");
            ActivityApprovemod();
        }
        

        public void Activity1Bldrc(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("RY221937", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Processes approved RFP and prepares APV");
            ActivityApprovemod();
        }
        public void Activity2(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("NC181328", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves APV");
            ActivityApprove();
        }
        
        public void Activity2Construction(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("NC181328", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves APV");
            ActivityApprove();
        }

        public void Activity2Bldrc(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("GD221871", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves APV");
            ActivityApprove();
        }

        public void Activity3(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("SF211665", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Receives APV and prepares check");
            ActivityApprove();
        }

        public void Activity4(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("SF211665", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Routing and Approval of Check");
            ActivityApprove();
        }

        public void Activity5(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("IT00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Liquidation of Advances");
            ActivityApprove();
        }

        public void Activity6(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("HY171244", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("GR/IR Creation");
            ActivityApprove();
        }

        public void Activity6Constructionbldrc(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("AP191481", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("GR/IR Creation");
            ActivityApprove();
        }

        public void Activity6BldrcNonCons(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("HY171244", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("GR/IR Creation");
            ActivityApprove();
        }

        public void Activity7(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JM211673", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Recording of Liquidation of Advances in SAP");
            ActivityApprove();
        }

        public void Activity7construction(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JC110470", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Recording of Liquidation of Advances in SAP");
            ActivityApprove();
        }

        public void Activity7bldrc(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("RY221937", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Recording of Liquidation of Advances in SAP");
            ActivityApprove();
        }

        public void Activity8(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("NC181328", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves Journal Voucher");
            ActivityApprove();
        }
        public void Activity8BLDRC(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("GD221871", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves Journal Voucher");
            ActivityApprove();
        }

        public void Activity8Construction(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("NC181328", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Checks and approves Journal Voucher");
            ActivityApprove();
        }

        public void Activity9(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("IT00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Receives Feedback and Closes the Ticket");
            ActivityApprove();
        }


        [Test]
        public void approvalA()
        {
            ApprovalDept(RequestNo);
            logout();
            ApprovalDiv(RequestNo);
        }


        [Test]
        public void approvalB()
        {

            ApprovalDept("23082798806");
            logout();
            ApprovalDiv("23082798806");
            logout();
            ApprovalGMPres("23082798806");
        }

        [Test]
        public void approvalC()
        {
            ApprovalDept("23082798807");
            logout();
            ApprovalDiv("23082798807");
            logout();
            ApprovalGMPres("23082798807");
        }

        [Test]
        public void approvalD()
        {
            ApprovalDept("23082798808");
            
        }

        [Test]
        public void approvalE()
        {
            ApprovalDept("23082798809");
            logout();
            ApprovalDiv("23082798809");
            logout();
            ApprovalBLRDC("23082798809");

        }
        [Test]
        public void approvalF()
        {
            ApprovalDept("23082798810");
            logout();
            ApprovalDiv("23082798810");
            logout();
            ApprovalLG("23082798810");

        }

        [Test]
        public void approvalG()
        {
            ApprovalDept("23082798811");
            logout();
            ApprovalDiv("23082798811");
            logout();
            ApprovalPPD("23082798811");

        }


        public void ActivityApprovemod()
        {
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoActivityApprove().Click();
            Assert.AreEqual(2, driver.Value.WindowHandles.Count);
            parentWindow = driver.Value.CurrentWindowHandle;

            driver.Value.SwitchTo().Window(driver.Value.WindowHandles[1]);
            IWebElement trantypes = driver.Value.FindElement(By.Id("0423_01_COND"));
            SelectDropdown(trantypes, "PO");
            driver.Value.FindElement(By.Id("txtPassword3")).SendKeys("12345678");
            driver.Value.FindElement(By.Id("cmdConditional")).Click();
            driver.Value.SwitchTo().Window(parentWindow);

        }



        public void FillupRequest(String ReqCat, String ExpCat, String Company, String GrpCat, String TranType)
        {
            LOGINActions("IT00", "12345678");
            CREATEREQUESTActions("ACCOUNTING REQUESTS", "REQUEST FOR PAYMENT - COD / Payment First & Liquidation", "SCR_RSH_0423_01");

            if(ReqCat != "")
            {
                IWebElement RequestCategories = driver.Value.FindElement(By.Id("FLD_042301_REQST_CAT"));
                SelectDropdown(RequestCategories, ReqCat);
            }
           
            if(ExpCat != "")
            {
                IWebElement ExpenseCategories = driver.Value.FindElement(By.Id("FLD_042301_EXPNSE"));
                SelectDropdown(ExpenseCategories, ExpCat);
            }


            if (Company != "")
            {
                IWebElement Companies = driver.Value.FindElement(By.Id("FLD_042301_COMP"));
                SelectDropdown(Companies, Company);
            }

            

            driver.Value.FindElement(By.Id("FLD_042301_CC")).SendKeys("TESTING");

            if (GrpCat != "")
            {
                IWebElement GroupCategories = driver.Value.FindElement(By.Id("FLD_TARGET_ACC"));
                SelectDropdown(GroupCategories, GrpCat);
            }

            if (TranType != "")
            {
                IWebElement TransactionTypes = driver.Value.FindElement(By.Id("FLD_042301_TRNSCT"));
                SelectDropdown(TransactionTypes, TranType);
            }

            

            driver.Value.FindElement(By.Id("FLD_042301_TR_DT")).SendKeys("Testing");
            driver.Value.FindElement(By.Id("FLD_042301_IVSOBS")).SendKeys("Testing");
            driver.Value.FindElement(By.Id("FLD_042301_PAYNAM")).SendKeys("Testing");
            driver.Value.FindElement(By.Id("FLD_042301_GROSS")).SendKeys("1000000");
            driver.Value.FindElement(By.Id("FLD_042301_EX_RFP")).SendKeys("1000000");
            driver.Value.FindElement(By.Id("FLD_042301_EXEMAIL")).SendKeys("1000000");

            SaveRequest();
            Finalize();

            RequestNo = GetRequestNo();
        }



        [Test]

        public void aaaaCreateReq()
        {
            FillupRequest("b. Approval up to President", "", "", "", "");
        }




        [Test]

        public void Runner()
        {

            
            Activity1(RequestNo);
            
            //Activity2(RequestNo);
            //logout();
            //Activity3(RequestNo);
            //logout();
            //Activity4(RequestNo);
            //logout();
            //Activity5(RequestNo);
            //logout();
            //Activity6(RequestNo);
            //logout();
            //Activity7(RequestNo);
            //logout();
            //Activity8(RequestNo);
            //logout();
            //Activity9(RequestNo);
            //logout();

        }


        private void Finalize()
        {
            //Finalize Request
            driver.Value.FindElement(By.Id("btnSubmit")).Click();

            //Control/Handle Alert to Click CANCEL
            Thread.Sleep(1000);
            driver.Value.SwitchTo().Alert().Dismiss();
            driver.Value.SwitchTo().Alert().Dismiss();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches("http://rush.sit.federalland.ph/RUSH_SIT/REQSTQUEUE/MYREQUESTS.aspx"));
        }
    }
}
