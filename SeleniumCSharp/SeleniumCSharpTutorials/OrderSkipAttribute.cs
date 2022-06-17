﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute 
    {
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
            driver.Close();
        }


    }
}
