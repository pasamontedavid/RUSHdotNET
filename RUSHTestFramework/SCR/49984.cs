using RUSHTestFramework.pageObjects;
using RUSHTestFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.SCR
{
    public class _49984:BaseConfig
    {

        String RequestNo;

        
        public void Test_B_Approval1()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("FM100411", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }


        public void Test_C_Approval2()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JU181369", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void Test_D_Approval3()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("AD100382", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        public void Test_E_Approval3()
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




        [Test]

        public void Test_F_Activity1_1()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("AP221954", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }

        [Test]

        public void Test_G_Activity1_2()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("AC222020", "12345678");
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

        public void Test_H_Activity2_1()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("AP221954", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }




        [Test]

        public void Test_I_Activity2_2()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("LT221916", "12345678");
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

        public void Test_J_Activity3_1()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("BA870004", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }

        [Test]

        public void Test_K_Activity3_2()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("CS130616", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }


        [Test]

        public void Test_K_Activity3_3()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("DF221912", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }

        [Test]

        public void Test_K_Activity3_4()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("ML110017", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }


        [Test]

        public void Test_K_Activity3_5()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("SF211665", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }


        [Test]

        public void Test_K_Activity3_6()
        {
            SCR_RSH_0323_07 obj = new SCR_RSH_0323_07(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JJ211722", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            //Thread.Sleep(3000);
            //WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            //workqueuepage.gotoSearchicon().Click();
            //workqueuepage.gotoRequestNoTxt().SendKeys(RequestNo);
            //workqueuepage.gotoSearchbutton().Click();
            //ActivityDescriptionChecker(obj.ExpActivity1_Desc());
            //ActivityApprove();
        }



    }
}
