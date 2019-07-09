using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TimeMaterials_Auto.Pages
{
    class HomePage
    {
        public void HomeSteps(IWebDriver driver)
        {
            //Click on administration bar
            IWebElement Adminbar = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Adminbar.Click();

            //Click on Time & Materials
            IWebElement TimeMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterials.Click();
        }
    }
}
