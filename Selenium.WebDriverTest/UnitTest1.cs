using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using System.Threading;

namespace Selenium.WebDriverTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            //search - box
            driver = new ChromeDriver();

            driver.Url = "https://www.trendyol.com/";

            driver.FindElement(By.ClassName(Utility.ModalClose)).Click();
            Thread.Sleep(1000);
            string searchValue = RandomString();
            driver.FindElement(By.ClassName(Utility.SearchBox)).SendKeys(searchValue);
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName(Utility.SearchBox)).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Random random = new Random();
            int randomProductNumber = random.Next(2, 5);
            driver.FindElement(By.XPath(Utility.GetProductPath(randomProductNumber))).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName(Utility.AddToBasket)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName(Utility.AccountBasket)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName(Utility.ITrash)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Utility.RemoveXPath)).Click();

            //bdd
        }

        private static Random random = new Random();
        public static string RandomString()
        {
            string[] strArr = { "televizyon", "yüz maskesi" };
            return strArr[random.Next(strArr.Length)];
        }
    }
}