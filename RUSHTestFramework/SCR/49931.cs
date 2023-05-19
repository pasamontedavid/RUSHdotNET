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
    public class _49931:BaseConfig
    {
        String RequestNo;

        [Test]
        public void Test_A_FieldsChecking()
        {
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("ADMIN REQUEST", "SPECIAL PERSONNEL SUPPORT", "SCR_RSH_0323_06");
            SCR_RSH_0323_06 obj = new SCR_RSH_0323_06(getDriver());
            DropdownChecker(obj.ExpectedParticulars(), obj.gotoParticulars());
            SystemdateChecker(obj.gotoRequestdate());
            DropdownChecker(obj.ExpectedManpower(), obj.gotoManpowerType());
            SystemdateChecker(obj.gotoDateNeeded());
        }

        [Test]

        public void Test_B_FillupRequestForm()
        {
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("ADMIN REQUEST", "SPECIAL PERSONNEL SUPPORT", "SCR_RSH_0323_06");
            SCR_RSH_0323_06 obj = new SCR_RSH_0323_06(getDriver());
            obj.gotoQuantityNumberofPersonnel().SendKeys("Test Only");
            obj.gotoTimeFrom().SendKeys("Test Only");
            obj.gotoTimeTo().SendKeys("Test Only");
            obj.gotoDetailsRquired().SendKeys("Test Only");
            obj.gotoDateNeeded().Clear();
            obj.gotoDateNeeded().SendKeys(DateTime.Today.AddDays(3).ToString("MM/dd/yyyy"));
            SaveRequest();
            FinalizeRequest();
            RequestNo = GetRequestNo();
        }


        [Test]
        public void Test_C_Approval1()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
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
        public void Test_D_Approval2()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
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
        public void Test_E_Approval3()
        {
            HR_LV_DEP_HD obj = new HR_LV_DEP_HD(getDriver());
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
        public void DateRequired_NotEqualToDateToday()
        {
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("ADMIN REQUEST", "SPECIAL PERSONNEL SUPPORT", "SCR_RSH_0323_06");
            SCR_RSH_0323_06 obj = new SCR_RSH_0323_06(getDriver());
            obj.gotoQuantityNumberofPersonnel().SendKeys("Test Only");
            obj.gotoTimeFrom().SendKeys("Test Only");
            obj.gotoTimeTo().SendKeys("Test Only");
            obj.gotoDetailsRquired().SendKeys("Test Only");

            driver.Value.FindElement(By.Id("cmdAdd")).Click();
            Thread.Sleep(1000);
            IAlert savealert = driver.Value.SwitchTo().Alert();
            String savealertmsg = savealert.Text;
            savealert.Accept();
            driver.Value.SwitchTo().ParentFrame();
            StringAssert.Contains("Date Required Field And Date Created Must not have Same Value", savealertmsg);

        }

        [Test]
        public void DateRequired_Atleast3daysUponRequest()
        {
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("ADMIN REQUEST", "SPECIAL PERSONNEL SUPPORT", "SCR_RSH_0323_06");
            SCR_RSH_0323_06 obj = new SCR_RSH_0323_06(getDriver());
            obj.gotoQuantityNumberofPersonnel().SendKeys("Test Only");
            obj.gotoTimeFrom().SendKeys("Test Only");
            obj.gotoTimeTo().SendKeys("Test Only");
            obj.gotoDetailsRquired().SendKeys("Test Only");
            obj.gotoDateNeeded().Clear();
            obj.gotoDateNeeded().SendKeys("04/12/2023");

            driver.Value.FindElement(By.Id("cmdAdd")).Click();
            Thread.Sleep(1000);
            IAlert savealert = driver.Value.SwitchTo().Alert();
            String savealertmsg = savealert.Text;
            savealert.Accept();
            driver.Value.SwitchTo().ParentFrame();
            StringAssert.Contains("Date Required (at least 3 working days from the date of request)", savealertmsg);

        }
    }
}
