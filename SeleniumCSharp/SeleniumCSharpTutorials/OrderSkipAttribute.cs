// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");


            IWebElement cookieButton = driver.FindElement(By.XPath(".//button[@title='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);

            IWebElement regButton = driver.FindElement(By.XPath("//a[@role='button'][@data-testid='open-registration-form-button']"));
            regButton.Click();
            Thread.Sleep(5000);

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("6");
        }

        /*
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
            Thread.Sleep(1000);
        }
        */
    }
}
