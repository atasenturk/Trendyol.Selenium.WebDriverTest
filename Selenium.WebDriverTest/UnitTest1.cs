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
            driver.FindElement(By.ClassName("search-box")).SendKeys(searchValue);
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("search-box")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Random random = new Random();
            int randomProductNumber = random.Next(2, 5);
            driver.FindElement(By.XPath(".//*[@id='search-app']/div/div[1]/div[2]/div[5]/div/div["+ randomProductNumber + "]/div[1]/a")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("add-to-basket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("account-basket")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("i-trash")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Sil']")).Click();

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

public static class Utility
{
    public const string ModalClose = "modal-close";
    public const string SearchBox = "search-box";
}