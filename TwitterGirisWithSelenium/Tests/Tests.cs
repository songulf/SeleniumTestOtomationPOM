using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitterGirisWithSelenium.Pages;

namespace TwitterGirisWithSelenium.Tests
{
    public class Tests:BasePage
    {
        public IWebDriver driver;


        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://twitter.com/login?lang=tr";
            driver.Manage().Window.Maximize();
            

            var Loginpage = new LoginPage(driver);
            ExitPage exitpage=Loginpage.Login("snglfl", "1234");   //sırasıyla geçerli bir e-posta ve şifre giriniz.
            Thread.Sleep(4000);
            exitpage.FillExit();





        }

        }
    }

