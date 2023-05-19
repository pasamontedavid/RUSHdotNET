using RUSHTestFramework.pageObjects;
using RUSHTestFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.SCR
{
    public class _49932:BaseConfig
    {
        String RequestNo;
        [Test]

        public void Test_A_FillupRequest()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            LOGINActions("IT00", "12345678");
            CREATEREQUESTActions("ADMIN REQUEST", "TRANSFER OF ASSET/ASSET MOVEMENT/ASSET WAREHOUSING", "SCR_RSH_0323_07");
            obj.gotoTypeItem().SendKeys("Test ONLY");
            obj.gotoCurrentLoca().SendKeys("Test ONLY");
            obj.gotoNewLoca().SendKeys("Test ONLY");
            obj.gotoDateRequired().Clear();
            obj.gotoDateRequired().SendKeys(DateTime.Today.AddDays(5) .ToString("MM/dd/yyyy"));
            obj.gotoReasonTransfer().SendKeys("Test ONly");
            obj.gotoUserItem().SendKeys("Testing");
            obj.gotoTagNum().SendKeys("112233");
            SaveRequest();
            FinalizeRequest();

            RequestNo = GetRequestNo();
        }

        [Test]
        public void Test_B_Approval1()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("jb201582", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }


        [Test]
        public void Test_C_Approval2()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("pv211633", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();

        }

        [Test]
        public void Test_D_Approval3()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("jb150942", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }


        [Test]
        public void Test_E_Activity1()
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
            ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            ActivityApprove();
        }


        [Test]
        public void Test_F_Activity2()
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
            ActivityDescriptionChecker(obj.ExpActivity2_Desc());
            ActivityApprove();
        }

        [Test]
        public void Test_G_Activity3()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("RD232074", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            ActivityDescriptionChecker(obj.ExpActivity3_Desc());
            ActivityExpectedTATChecker(obj.ExpActivity3_TAT());
            ActivityApprove();
        }

        [Test]
        public void Test_H_Activity4()
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
            ActivityDescriptionChecker(obj.ExpActivity4_Desc());
            ActivityApprove();
        }

        [Test]
        public void Test_I_Activity5()
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
            ActivityDescriptionChecker(obj.ExpActivity5_Desc());
            ActivityApprove();
        }

        [Test]
        public void Test_J_Activity6()
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
            ActivityDescriptionChecker(obj.ExpActivity6_Desc());
            ActivityApprove();
        }

        [Test]
        public void Test_K_Activity7()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("IT00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23122798788");
            workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity7_Desc());
            ActivityApprove();
        }


        [Test]
        public void Test_L_Activity8()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("IT00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23122798788");
            workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity8_Desc());
            ActivityApprove();
        }


        [Test]
        public void Test_M_Activity9()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("KM191441", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23122798788");
            workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity9_Desc());
            ActivityApprove();
        }

        [Test]
        public void Test_N_Activity10()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23122798788");
            workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity10_Desc());
            ActivityApprove();
        }
    }
}
