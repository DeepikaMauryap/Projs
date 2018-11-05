using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
   public  class  SeleniumMethod
    {
        private string value;

        public void EnterText(IWebDriver driver,string element, string value, string elementtype)
        {
            if(elementtype =="id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            
        }
        public void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "name")
                driver.FindElement(By.Name(element)).Click();
       }

        public void SelectDropDown(IWebDriver driver, string element, string name, string elementtype)
        {
            //sele

        }
       


    }

    
}
