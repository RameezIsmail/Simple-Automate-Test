using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeMaterials_Auto.Pages
{
    class TMpage
    {
        public void TMCreate(IWebDriver driver)
        {
            //Click on create new button
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();

            //Interact with TypeCode dropdown menu
            IWebElement TypeCodeDropdownmenu = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            TypeCodeDropdownmenu.Click();

            //Click on "Time" under TypeCode dropdown menu
            IWebElement TypeCodeTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            TypeCodeTime.Click();

            //Enter in code textbox
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("Rammy");

            //Enter in Description textbox
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("Warehouse");

            //Enter number in price per unit textbox
            IWebElement Pricetextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Pricetextbox.SendKeys("400");

            //Click on save button
            IWebElement Savebutton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Savebutton.Click();

            Thread.Sleep(1000);

            //Navigate to last page
            IWebElement Lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Lastpage.Click();

            //To find if the test went successful or not
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]")).Text == "Rammy")

            {
                Console.WriteLine("Create sucessfully, test passed.");
            }
            else
            {
                Console.WriteLine("Create test Failed");
            }

            
        }

        public void TMEdit(IWebDriver driver)
        {
            //Pause the the browser so the automation can catch up
            Thread.Sleep(1000);

            //Click edit button
            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
            editbutton.Click();

            //Clear previous code name and add new one
            IWebElement codenamechange = driver.FindElement(By.Id("Code"));
            codenamechange.Clear();
            codenamechange.SendKeys("Amazing");

            //Clear previous description name and add new one
            IWebElement Descnamechange = driver.FindElement(By.Id("Description"));
            Descnamechange.Clear();
            Descnamechange.SendKeys("Countdown");

            /*IWebElement Pricechange = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Pricechange.Clear();
            Pricechange.SendKeys("200");
            */

            //Click save button
            IWebElement Savebutton1 = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Savebutton1.Click();

            Thread.Sleep(1000);

            //Navigate to last page
            IWebElement Lastpageagain = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Lastpageagain.Click();

            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]")).Text == "Amazing");

            /*if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]")).Text == "Amazing")

            {
                Console.WriteLine("Edit sucessfully, test passed.");
            }
            else
            {
                Console.WriteLine("Edit test Failed");
            }*/
        }

        public void TMDelete(IWebDriver driver)
        {
            //Click Delete button
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[2]")).Click();

        }
    }
}
