using OpenQA.Selenium;
using RUSHTestFramework.pageObjects;
using RUSHTestFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.SCR
{
    public class _50580:BaseConfig
    {
        String RequestNo = "23082798815";
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


        public void AppOwnerApproval1(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("VR980088", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void AppOwnerApproval2(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("MF171204", "12345678");
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
            LOGINActions("VR980088", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Create Rush Request for the purchase of office supplies");
            ActivityApprove();
        }

        public void Activity2(String RequestNo)
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker("Received and Closed Ticket");
            ActivityApprove();
        }

        public void FillupRequest(String qty, String unitmsr, String crrntStck)
        {
            LOGINActions("IT00", "12345678");
            CREATEREQUESTActions("SALES ACTIVATION REQUEST", "REQUEST FOR OFFICE SUPPLIES(TONER-INK CARTRIDGE)", "SCR_RSH_0523_01");

            SCR_RSH_0523_01 obj = new SCR_RSH_0523_01(driver.Value);

            obj.GotoQuantity().SendKeys(qty);
            obj.GotoUnitMeasure().SendKeys(unitmsr);
            obj.GotoCurrentStock().SendKeys(crrntStck);
            SaveRequest();
            FinalizeRequest();

            RequestNo = GetRequestNo();
        }


        [Test]
        public void Executer()
        {
            RequestNo = "23202798826";
            //FillupRequest("123","23","0");
            //logout();
            //ApprovalDept(RequestNo);
            //logout();
            AppOwnerApproval1(RequestNo);
            logout();
            AppOwnerApproval2(RequestNo);
            //logout();
            //Activity1(RequestNo);
            //logout();
            //Activity2(RequestNo);
        }
    }
}
