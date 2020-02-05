using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TwitterGirisWithSelenium.Pages
{
    public class LoginPage : BasePage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How=How.Name,Using = "session[username_or_email]")]
        public IWebElement EPosta { get; set; }

        [FindsBy(How=How.Name,Using = "session[password]")]
        public IWebElement Password { get; set; }

        [FindsBy(How=How.XPath,Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/main[1]/div[1]/div[1]/form[1]/div[1]/div[3]")]
        public IWebElement GirisBtn { get; set; }

       

        public ExitPage Login(string Eposta,string password)
        {
            EPosta.SendKeys(Eposta);
            Password.SendKeys(password);
            GirisBtn.Click();
            return new ExitPage(driver);

            

        }
        


    }
}