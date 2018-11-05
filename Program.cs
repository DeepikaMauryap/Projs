using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    [TestFixture]
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        SeleniumMethod selenium = new SeleniumMethod();

        static void Main(string[] args)
        {
          
          


        }
        [SetUp]
        public void Initialize() {
            driver.Navigate().GoToUrl("http://localhost:50586/LoginPage");
            Console.WriteLine("Opened url");

        }

        [Test]
        public void ExecuteTest() {
            /*        
            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("Deepika Padukone");
            Console.WriteLine("Execute test");*/
            selenium.EnterText(driver, "TextBox1", "Deepika", "name");

            selenium.EnterText(driver, "TextBox2", "123456", "name");

            selenium.Click(driver, "btnLogin", "name");


        }

        [TearDown]
        public void Cleanup() {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
