using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {

        [Test]
        [Author("Bogumił","bogumil_latuszek@o2.pl")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;

                //IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
                IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='jhgf']"));


                emailTxtField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                string workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\SeleniumCSharpTutorials\\screenshots\\scr1.jpg";

                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile( path , ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.gmail.com/");
            //list.Add("https://www.youtube.com/");
            return list;

        }


        /*[Test]
        [Author("Bogumił", "bogumil_latuszek@o2.pl")]
        [Description("Facebook login verify")]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTxtField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTxtField.SendKeys("Selenium C#");
            driver.Close();
        }*/

    }

}
