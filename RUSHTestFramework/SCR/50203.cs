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


        public void Activity1(String RequestNo)
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
            ActivityDescriptionChecker("Processes approved RFP and prepares APV");
            ActivityApprove();
        }


        public void Activity2(String RequestNo)
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

        public void Activity6Construction(String RequestNo)
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
            ApprovalDept("23012798795");
            logout();
            ApprovalDiv("23012798795");
        }


        [Test]
        public void approvalB()
        {
            ApprovalDept("23022798796");
            logout();
            ApprovalDiv("23022798796");
            logout();
            ApprovalGMPres("23022798796");
        }

        [Test]
        public void approvalC()
        {
            ApprovalDept("23022798797");
            logout();
            ApprovalDiv("23022798797");
            logout();
            ApprovalGMPres("23022798797");
        }

        [Test]
        public void approvalD()
        {
            ApprovalDept("23022798798");
            
        }

        [Test]
        public void approvalE()
        {
            ApprovalDept("23022798799");
            logout();
            ApprovalDiv("23022798799");
            logout();
            ApprovalBLRDC("23022798799");

        }
        [Test]
        public void approvalF()
        {
            ApprovalDept("23022798800");
            logout();
            ApprovalDiv("23022798800");
            logout();
            ApprovalLG("23022798800");

        }


        public void ActivityApprovemod()
        {
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoActivityApprove().Click();
            Assert.AreEqual(2, driver.Value.WindowHandles.Count);
            parentWindow = driver.Value.CurrentWindowHandle;

            driver.Value.SwitchTo().Window(driver.Value.WindowHandles[1]);
            workqueuepage.gotoSimpleApprovalPassword().SendKeys("12345678");
            workqueuepage.gotoSimpleApprovalSubmit().Click();
            driver.Value.SwitchTo().Window(parentWindow);

        }

    }
}
