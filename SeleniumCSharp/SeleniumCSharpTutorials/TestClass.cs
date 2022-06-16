﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
            driver.Quit();
        }
    }
}
