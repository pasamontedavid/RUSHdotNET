using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RUSHTestFramework.pageObjects;
using RUSHTestFramework.Utilities;
using System.Collections.Generic;

namespace RUSHTestFramework
{
    public class Tests:BaseConfig
    {
        String parentWindow,RequestCode;

        [Test]
        public void Test_A_FieldsChecking()
        {
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("HR REQUESTS", "APPLICATION FOR LEAVE UNTIL DEPARTMENT HEAD LEVEL APPROVAL", "HR_LV_DEP_HD");
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            DropdownChecker(obj.ExpectedParticulars(), obj.gotoParticulars());
            SystemdateChecker(obj.gotoRequestdate());
            DecimalInputChecker(obj.gotoBalfield());
            DropdownChecker(obj.ExpectedCertify(), obj.gotoCertify());
            SystemdateChecker(obj.gotoLeavefrom());
            SystemdateChecker(obj.gotoLeaveto());
            SystemdateChecker(obj.gotoDateOfReturn());


        }

        [Test]
        public void Test_B_Requestform()
        {
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("HR REQUESTS", "APPLICATION FOR LEAVE UNTIL DEPARTMENT HEAD LEVEL APPROVAL", "HR_LV_DEP_HD");
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            //Particular
            SelectDropdown(obj.gotoParticulars(), "VACATION LEAVE");
            //Date Created
            InputTextbox(obj.gotoRequestdate(), DateTime.Today.ToString("m/d/yyyy"));
            //Balance
            InputTextbox(obj.gotoBalfield(), "12.00");
            //certify
            SelectDropdown(obj.gotoCertify(), "Yes");
            //LeaveFrom
            InputTextbox(obj.gotoLeavefrom(), "03/02/2023");
            //Leaveto
            InputTextbox(obj.gotoLeaveto(), "03/02/2023");
            //Number of Days
            InputTextbox(obj.gotoNumberOfDays(), "1");
            //Reasons
            InputTextbox(obj.gotoReasons(), "THIS IS TESTING");
            SaveRequest();
            FinalizeRequest();
            MyRequestsPage myrequestpage= new MyRequestsPage(getDriver());
            RequestCode = myrequestpage.gotoRequestnoLocator().Text;
            TestContext.WriteLine(RequestCode);


        }

        [Test]
        public void Test_C_ApprovalCheking()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JB201582", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys(RequestCode);
            workqueuepage.gotoSearchbutton().Click();
            Thread.Sleep(2000);
            ApprovalStatusChecker("IN-PROCESS", 1);
            

        }

        //[Test]

        //public void Test_D_Approval()
        //{
        //    Thread.Sleep(2000);
        //    LOGINActions("JB201582", "12345678");
        //    Thread.Sleep(2000);
        //    WorkQueuePage();
        //    Thread.Sleep(3000);
        //    WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
        //    workqueuepage.gotoSearchicon().Click();
        //    workqueuepage.gotoRequestNoTxt().SendKeys(RequestCode);
        //    workqueuepage.gotoSearchbutton().Click();   
        //    Thread.Sleep(2000);
        //    workqueuepage.gotoApproveEndorse().Click();
        //    SimpleApprove();
        //}

        [Test]

        public void test_lang()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("JF110456", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23032798744");
            workqueuepage.gotoSearchbutton().Click();
            Thread.Sleep(2000);
            ActivityClusterChecker(obj.ExpectedActivity1ClusterMem(), 1, 1);
            
        }


        [Test]
        public void testp6Activit1()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("pv211633", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }
        [Test]
        public void testp6Approve3()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("jb150942", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            SimpleApprove();
        }

        [Test]
        public void testp6Activity1()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("mc161084", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            ActivityApprove();
        }
        [Test]
        public void testp6Activity2()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            ActivityApprove();
        }

        [Test]
        public void testp6Activity3()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            ActivityApprove();
        }
        [Test]
        public void testp6Activity4()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("km191441", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            ActivityApprove();
        }
        [Test]
        public void testp6Activity5()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
            Thread.Sleep(2000);
            LOGINActions("it00", "12345678");
            Thread.Sleep(2000);
            WorkQueuePage();
            Thread.Sleep(3000);
            WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
            workqueuepage.gotoSearchicon().Click();
            workqueuepage.gotoRequestNoTxt().SendKeys("23112798779");
            workqueuepage.gotoSearchbutton().Click();
            ActivityApprove();
        }
    }
}