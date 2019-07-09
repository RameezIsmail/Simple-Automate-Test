using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TimeMaterials_Auto.Pages
{
    class Login
    {

        public void loginSteps(IWebDriver driver)
        {

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

            Assert.That(helloHari.Text, Is.EqualTo("Hello hari!"));

            /*if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Sccessfully, login test passed");
            }
            else
            {
                Console.WriteLine("Logged in failed, login test failed");
            }*/
        }
    }
}
