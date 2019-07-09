using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeMaterials_Auto.Helpers;
using TimeMaterials_Auto.Pages;

namespace TimeMaterials_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
           


        }

        [SetUp]
        public void Login()
        {
            //define driver
            CommonDriver.driver = new ChromeDriver();

            //Login action
            Login loginObj = new Login();
            loginObj.loginSteps(CommonDriver.driver);

            //Navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.HomeSteps(CommonDriver.driver);
        }

        [Test]
        public void TMCreate()
        {
            //Create TM
            TMpage tmObj = new TMpage();
            tmObj.TMCreate(CommonDriver.driver);

        }

        [Test]
        public void TMEdit()
        {
            //Edit TM
            TMpage tmObj = new TMpage();
            tmObj.TMEdit(CommonDriver.driver);
        }

        [Test]
        public void TMDelete()
        {
            //Delete TM
            //TMpage tmObj = new TMpage();
           // tmObj.TMDelete(CommonDriver.driver);
        }

        [TearDown]
        public void Finish()
        {
            CommonDriver.driver.Quit();
        }
    }
}
