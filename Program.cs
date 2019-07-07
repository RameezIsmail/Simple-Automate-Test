using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeMaterials_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //launch chrome browser
            IWebDriver driver = new ChromeDriver();

            //Maximize the Chrome browser window
            driver.Manage().Window.Maximize();

            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //Enter username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Enter password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Click on login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Validate if the user had logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Sccessfully, login test passed");
            }
            else
            {
                Console.WriteLine("Logged in failed, login test failed");
            }

            //Click on administration bar
            IWebElement Adminbar = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Adminbar.Click();

            //Click on Time & Materials
            IWebElement TimeMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterials.Click();

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
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[1]")).Text == "Rammy")
            {
                Console.WriteLine("Create sucessfully, test passed.");
            }
            else
            {
                Console.WriteLine("Create test Failed");
            }
            Thread.Sleep(1000);
            //Click Delete button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[2]")).Click();


        }
    }
}
