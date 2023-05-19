using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.pageObjects
{
    public class WorkQueuePage
    {

        private IWebDriver driver;
        public WorkQueuePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //Search
        [FindsBy(How = How.Id, Using = "btnImgSearch")]
        private IWebElement Searchicon;

        public IWebElement gotoSearchicon()
        {
            return Searchicon;
        }


        //RequestNoTxt
        [FindsBy(How = How.Id, Using = "txtReqstNum")]
        private IWebElement RequestNoTxt;

        public IWebElement gotoRequestNoTxt()
        {
            return RequestNoTxt;
        }

        //Searchbutton
        [FindsBy(How = How.Id, Using = "cmdSearch2")]
        private IWebElement Searchbutton;

        public IWebElement gotoSearchbutton()
        {
            return Searchbutton;
        }

        //ApproveEndorse
        [FindsBy(How = How.Id, Using = "Button2")]
        private IWebElement ApproveEndorse;

        public IWebElement gotoApproveEndorse()
        {
            return ApproveEndorse;
        }

        //SimpleApprovalPassword
        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement SimpleApprovalPassword;

        public IWebElement gotoSimpleApprovalPassword()
        {
            return SimpleApprovalPassword;
        }

        //SimpleApprovalSubmit
        [FindsBy(How = How.Id, Using = "cmdSubmit")]
        private IWebElement SimpleApprovalSubmit;
        public IWebElement gotoSimpleApprovalSubmit()
        {
            return SimpleApprovalSubmit;
        }

        //ActivityApprove
        [FindsBy(How = How.Id, Using = "cmdApprove")]
        private IWebElement ActivityApprove;
        public IWebElement gotoActivityApprove()
        {
            return ActivityApprove;
        }


    }
}
