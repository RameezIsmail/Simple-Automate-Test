using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using TimeMaterials_Auto.Helpers;
using TimeMaterials_Auto.Pages;

namespace TimeMaterials_Auto.HookUp
{
    [Binding]
    public class TMSteps
    {
        [Given(@"I have logged in to Time and Material portal successfully")]
        public void GivenIHaveLoggedInToTimeAndMaterialsPortalSuccessfully()
        {
            //define driver
            CommonDriver.driver = new ChromeDriver();

            //Login action
            Login loginObj = new Login();
            loginObj.loginSteps(CommonDriver.driver);

        }
        [Given(@"I have navigated to TM page")]
        public void GivenIHaveNavigatedToTMPage()
        {
            //Navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.HomeSteps(CommonDriver.driver);

        }

        [Then (@"I should be able to create material with valid details successfully")]
        public void ThenIShouldAbleToCreateMaterialWithValidDetailsSuccessfully()
        {
            //Create TM
            TMpage tmObj = new TMpage();
            tmObj.TMCreate(CommonDriver.driver);

        }


    }
}
