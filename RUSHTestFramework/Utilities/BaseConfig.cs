using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.DevTools.V106.Target;
using RUSHTestFramework.pageObjects;
using System.Collections;
using System.Diagnostics;
using RUSHTestFramework.Utilities.BuiltInCommands;

namespace RUSHTestFramework.Utilities
{
    public class BaseConfig
    {
        public ExtentReports EXTENTREPORTS;
        public ExtentTest test;

        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public WebDriverWait wait;

        public Actions act;
        public String parentWindow;
        //report
        [OneTimeSetUp]
        public void reportSetup()
        {
            string WorkDirectory = Environment.CurrentDirectory;
            string ProjectDirectory = Directory.GetParent(WorkDirectory).Parent.Parent.FullName;
            string TestreportPATH = ProjectDirectory + "//TestReport.html";
            var htmlReporter = new ExtentHtmlReporter(TestreportPATH);
            EXTENTREPORTS = new ExtentReports();
            EXTENTREPORTS.AttachReporter(htmlReporter);
            EXTENTREPORTS.AddSystemInfo("System", "RUSH.Net");
            EXTENTREPORTS.AddSystemInfo("Host Name", "http://rush.sit.federalland.ph/RUSH_SIT/RushLogin.aspx");
            EXTENTREPORTS.AddSystemInfo("Environtment", "SIT");
            EXTENTREPORTS.AddSystemInfo("Tester", "David Philip Pasamonte");

        }


        [SetUp]
        public void OpenBrowser()
        {
            test = EXTENTREPORTS.CreateTest(TestContext.CurrentContext.Test.Name);
            //setup chrome driver 
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("window-size=1920,1080");
            //chromeOptions.AddArguments("headless");
            
            driver.Value = new ChromeDriver(chromeOptions);

            driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Value.Url = "http://rush.sit.federalland.ph/RUSH_SIT/REQSTQUEUE/MYREQUESTS.aspx";
            wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(60));
            act = new Actions(driver.Value);
        }


        [TearDown]
        public void close()
        {
            var testresult = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var Messagelog = TestContext.CurrentContext.Result.Message;
            string contextline = TestContext.CurrentContext.Result.ToString();
            String filename = "Screenshot" + DateTime.Now.ToString("h_mm_ss") + ".png";
            if (testresult == TestStatus.Failed)
            {
                test.Fail("TEST FAILED", captureScreenShot(driver.Value, filename));
                test.Log(Status.Info, "LOGTRACE" + stacktrace);
                if (Messagelog != null)
                {
                    test.Log(Status.Fail, "Message: " + Messagelog);
                }
            }
            else if (testresult == TestStatus.Passed)
            {
                test.Pass("TEST PASSED", captureScreenShot(driver.Value, filename));
                if (Messagelog != null)
                {
                    test.Log(Status.Pass, "Message: " + Messagelog);
                   
                }
                if (contextline != null)
                {
                    test.Log(Status.Pass, "Message: " + contextline);

                }

            }
            EXTENTREPORTS.Flush();
            Thread.Sleep(2000);
            driver.Value.Quit();
        }

        public void logout()
        {
            driver.Value.FindElement(By.CssSelector(".toplink")).Click();
            //Control/Handle alert to click OK
            driver.Value.SwitchTo().Alert().Accept();
            //Control the main Browser
            driver.Value.SwitchTo().DefaultContent();

        }


        public MediaEntityModelProvider captureScreenShot(IWebDriver driver, String ScreenshotName)
        {

            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, ScreenshotName).Build();
        }

        public IWebDriver getDriver()
        {
            return driver.Value;
        }



        //Actions START

                //Login
                public void LOGINActions(String UserID, String Password)
                {
                    LoginPage loginPage = new LoginPage(driver.Value);

            //USERID input
                    loginPage.gotoLoginID().Clear();
                    loginPage.gotoLoginID().Click();
                    loginPage.gotoLoginID().SendKeys(UserID);
                    //PASSWORD input
                    loginPage.gotoPassword().Click();
                    loginPage.gotoPassword().SendKeys(Password);
                    //LOGIN BUTTON
                    loginPage.gotoSubmit().Click();
                    //URLChecker(loginPage.LandingPage());
                    USERChecker(UserID.ToUpper());
            

                }

                //Create Request

                public void CREATEREQUESTActions(String Category,String RequestType, String ReqCode)
                {
                    Category.ToUpper();
                    RequestType.ToUpper();
                    MyRequestsPage myrequestsPage = new MyRequestsPage(driver.Value);
                    act.MoveToElement(myrequestsPage.gotoMyrequest()).Perform();
                    myrequestsPage.gotoMyrequests().Click();
                    URLChecker(myrequestsPage.MyrequestsLandingPage());
                    IWebElement Categories = myrequestsPage.gotoRequestCategory();
                    SelectElement SelectCategory = new SelectElement(Categories);
                    SelectCategory.SelectByText(Category);
                    Thread.Sleep(1000);

                    IWebElement RequestTypes = myrequestsPage.gotoRequestType();
                    SelectElement SelectRequestTypes = new SelectElement(RequestTypes);
                    SelectRequestTypes.SelectByText(RequestType);
                    Thread.Sleep(1000);
                    myrequestsPage.gotoConfirm().Click();
                    URLChecker(myrequestsPage.RequestLandingPage(ReqCode));
                    REQUESTChecker(Category, RequestType);
                    
                }
                
                //Go to Work Queue Page

                public void WorkQueuePage()
                {
                    MyRequestsPage myrequestsPage = new MyRequestsPage(driver.Value);
                    act.MoveToElement(myrequestsPage.gotoMyworkqueue()).Perform();
                    myrequestsPage.gotoWorkqueue().Click();
                    URLChecker("http://rush.sit.federalland.ph/RUSH_SIT/WORKQUEUE/WORKQUEUE.aspx");
                }



                public void SimpleApprove()
                {
                    WorkQueuePage workqueuepage = new WorkQueuePage(getDriver());
                    workqueuepage.gotoApproveEndorse().Click();
                    Assert.AreEqual(2, driver.Value.WindowHandles.Count);
                    parentWindow = driver.Value.CurrentWindowHandle;

                    driver.Value.SwitchTo().Window(driver.Value.WindowHandles[1]);
                    workqueuepage.gotoSimpleApprovalPassword().SendKeys("12345678");
                    workqueuepage.gotoSimpleApprovalSubmit().Click();
                    driver.Value.SwitchTo().Window(parentWindow);
                    
                }

        public void ActivityApprove()
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
        private string RequestNo;
        public String GetRequestNo()
        {
            MyRequestsPage myrequestpage = new MyRequestsPage(getDriver());
            RequestNo = myrequestpage.gotoRequestnoLocator().Text;

            return RequestNo;
        }

        //Actions END       







        //Fillup RequestForm
        public void SelectDropdown(IWebElement locator, String value)
                {
                    SelectElement choose = new SelectElement(locator);
                    choose.SelectByText(value);
                }

                public void InputTextbox(IWebElement locator, String value)
                {
                    locator.Clear();
                    locator.SendKeys(value);
                }  
                
                public void SaveRequest()
                {
                    driver.Value.FindElement(By.Id("cmdAdd")).Click();
                    Thread.Sleep(2000);
                    //Control/Handle alert to click OK
                    driver.Value.SwitchTo().Alert().Accept();
                    //Control the main Browser
                    driver.Value.SwitchTo().DefaultContent();
                }                                           

                public void FinalizeRequest()
                {
                    //Finalize Request
                    driver.Value.FindElement(By.Id("btnSubmit")).Click();

            //Control/Handle Alert to Click CANCEL
                    Thread.Sleep(1000);
                    driver.Value.SwitchTo().Alert().Dismiss();
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches("http://rush.sit.federalland.ph/RUSH_SIT/REQSTQUEUE/MYREQUESTS.aspx"));
                }



        //End Fillup RequestForm






        //CHECKER START

        //checking of URL if match with expected
        public void URLChecker(String Expected)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(Expected));
            StringAssert.Contains(Expected, driver.Value.Url);
            TestContext.WriteLine("Expected URL: " + Expected);
            TestContext.WriteLine("Actual URL: " + driver.Value.Url);

        }

        //checking of current user if match with expected
        public void USERChecker(String UserID)
        {
            String actual = driver.Value.FindElement(By.XPath("//body[1]/form[1]/table[1]/tbody[1]/tr[2]/td[2]/table[1]/tbody[1]/tr[3]/td[1]/table[1]/tbody[1]/tr[3]/td/b")).Text;
            StringAssert.Contains(UserID, actual);
            TestContext.WriteLine("Expected User: " + UserID);
            TestContext.WriteLine("Actual USER: " + actual);

        }

        //checking of Request created
        public void REQUESTChecker(String Category, String RequestType)
        {
            String actual = driver.Value.FindElement(By.CssSelector("#lblReqstDesc b")).Text;
            String expected = Category + " - " + RequestType;
            StringAssert.Contains(expected, actual);
            TestContext.WriteLine("Expected Request: " + expected);
            TestContext.WriteLine("Actual Request: " + actual);
        }

        //Dropdown Checker

        public void DropdownChecker(String[] expectedoptions, IWebElement locator)
        {
            String[] Expected = new String[expectedoptions.Count()];
            String[] ActualParticulars = new string[expectedoptions.Count()];
            IWebElement Particular = locator;
            SelectElement Particulars = new SelectElement(Particular);
            IList<IWebElement> options = Particulars.Options;
            for (int i = 0; i < options.Count(); i++)
            {
                ActualParticulars[i] = options.ElementAt(i).Text;
            }
            Assert.AreEqual(expectedoptions, ActualParticulars);
        }

        public void NumericInputChecker(IWebElement locator)
        {
            locator.SendKeys("AaEeIiOoUu1234567890");
            string actual = locator.GetAttribute("value");
            bool isNumeric = actual.All(char.IsDigit);
            TestContext.WriteLine(actual);
            Assert.IsTrue(isNumeric);
        }

        public void AlphainputChecker(IWebElement locator)
        {
            locator.SendKeys("AaEeIiOoUu1234567890");
            string actual = locator.GetAttribute("value");
            bool isTextOnly = actual.All(char.IsLetter);
            Assert.IsTrue(isTextOnly);
        }

        public void SystemdateChecker(IWebElement locator)
        {
            string actual = locator.GetAttribute("value");
            string DateToday = DateTime.Now.ToString("MM/dd/yyyy");
            if (DateToday != actual)
            {
                DateToday = DateTime.Now.ToString("M/d/yyyy");
            }
            StringAssert.Contains(DateToday, actual);
        }


        public void DecimalInputChecker(IWebElement locator)
        {
            bool isDecimal;
            locator.SendKeys("AaEeIiOoUu1234567890");
            string actual = locator.GetAttribute("value");
            if (Decimal.TryParse(actual, out decimal value))
            {
                isDecimal = true;
            }
            else
            {
                isDecimal = false;
            }
            TestContext.WriteLine(actual);
            Assert.IsTrue(isDecimal);
        }



        public void textboxValueChecker(IWebElement locator, String value)
        {
            string actual = locator.GetAttribute("value");
            string expected = value;

            StringAssert.Contains(expected, actual);
        }

        

       
        




        //Activity Start
        public void ActivityDescriptionChecker(String expecteddescriptions)
        {
            //totalapproval++;
            //int value = totalapproval + activityno;
            String locator = "#_ctl26_grdHistory .selected td:nth-child(1)";
            String Actual = driver.Value.FindElement(By.CssSelector(locator)).Text;
            
            StringAssert.Contains(expecteddescriptions.ToUpper(), Actual.ToUpper());


        }

        public void ActivityAssigntoChecker(String expectedassignee)
        {
            //totalapproval++;
            //int value = totalapproval + activityno;
            String locator = "#_ctl26_grdHistory .selected td:nth-child(2)";
            String Actual = driver.Value.FindElement(By.CssSelector(locator)).Text;
            StringAssert.Contains(expectedassignee, Actual);


        }

        public void ActivityExpectedTATChecker(String expecteddescriptions)
        {
            Thread.Sleep(3000);
            //totalapproval++;
            //int value = totalapproval + activityno;
            String locator = "#_ctl26_grdHistory .selected td:nth-child(5)";
            String Actual = driver.Value.FindElement(By.CssSelector(locator)).Text;
            StringAssert.Contains(expecteddescriptions, Actual);
        }

        public void ActivityClusterChecker(String[] expectedClusterMem, int totalapproval, int activityno)
        {
            Thread.Sleep(3000);
            totalapproval++;
            int value = totalapproval + activityno;
            String locator = "#_ctl26_grdHistory .selected:nth-child(" + value.ToString() + ") > td:nth-child(2)";
            String ClusterName = driver.Value.FindElement(By.CssSelector(locator)).Text;

            TestContext.WriteLine(ClusterName);
            parentWindow = driver.Value.CurrentWindowHandle;
            driver.Value.SwitchTo().NewWindow(WindowType.Tab);
            driver.Value.Url = "http://rush.sit.federalland.ph/RUSH_SIT/RushLogin.aspx?logout=yes";
            string clusterwin = driver.Value.CurrentWindowHandle;
            driver.Value.SwitchTo().Alert().Accept();
            driver.Value.SwitchTo().Window(clusterwin);
            LoginPage loginPage = new LoginPage(getDriver());
            loginPage.gotoLoginID().Clear();
            loginPage.gotoLoginID().Click();
            loginPage.gotoLoginID().SendKeys("IT00");
            //PASSWORD input
            loginPage.gotoPassword().Click();
            loginPage.gotoPassword().SendKeys("12345678");
            //LOGIN BUTTON
            loginPage.gotoSubmit().Click();
            URLChecker("http://rush.sit.federalland.ph/RUSH_SIT/WorkQueue/WorkQueue.aspx");

            Actions a = new Actions(driver.Value);
            a.MoveToElement(driver.Value.FindElement(By.Id("e0_15i"))).Perform();
            a.Click(driver.Value.FindElement(By.Id("e0_17i"))).Perform();
            driver.Value.FindElement(By.Id("txtDescS")).SendKeys(ClusterName);
            driver.Value.FindElement(By.Id("cmdSearch")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("dg__ctl2_imgView")).Click();

            // locator cluster member names #Cluster_User_dg .MainTableRow td:nth-child(2)
            Assert.AreEqual(2, driver.Value.WindowHandles.Count);
        }



        //Activity END


        //Approval START

        public void ApprovalAssigntoChecker(String[] expectedassignee, int approvalno)
        {
            approvalno++;
            int value = approvalno;
            String locator = "#_ctl26_grdHistory .MainTableRow:nth-child(" + value.ToString() + ") > td:nth-child(2)";
            String Actual = driver.Value.FindElement(By.CssSelector(locator)).Text;
            TestContext.WriteLine(Actual);
        }

        public void ApprovalStatusChecker(String Expected, int approvalno)
        {
            approvalno++;
            int value = approvalno;
            String locator = "#_ctl26_grdHistory .MainTableRow:nth-child(" + value.ToString() + ") > td:nth-child(7)";
            String Actual = driver.Value.FindElement(By.CssSelector(locator)).Text;
            TestContext.WriteLine(Actual);
        }


        //Approval END





        //CHECKER END











    }
}
