using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitterGirisWithSelenium.Pages
{
    public class ExitPage:BasePage
    {
        public IWebDriver driver;
        public ExitPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);


        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/header[1]/div[1]/div[1]/div[1]/div[1]/div[2]/nav[1]/div[1]/div[1]/div[2]/span[1]")]
        public IWebElement MoreBtn { get; set; }


        [FindsBy(How=How.XPath,Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[12]/a[1]/div[1]/div[1]/span[1]")]
        public IWebElement CıkısYapBtn { get; set; }

        [FindsBy(How=How.XPath,Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[2]/div[1]/span[1]/span[1]")]
        public IWebElement LogOutBtn { get; set; }
        public void FillExit()
        {
            MoreBtn.Click();
            Thread.Sleep(2000);
            CıkısYapBtn.Click();
            Thread.Sleep(2000);
            LogOutBtn.Click();
        }

    }
}
