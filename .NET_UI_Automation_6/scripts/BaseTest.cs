using _NET_UI_Automation_6.pages;
using _NET_UI_Automation_6.utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
	public class BaseTest
	{
        public static IWebDriver driver;
        public Actions actions;

        public BasePage basePage;
        public FrontendTestingPage frontendTestingPage;
        public MockInterviewsPage mockInterviewsPage;

        // Before - set up actions
        [SetUp]
        public void SetUp()
        {
            driver = Driver.GetDriver();
            actions = new Actions(driver);
            // Navigate to url
            driver.Navigate().GoToUrl("https://techglobal-training.com/");
        }

        // After - teardown actions
        [TearDown]
        public void TearDown()
        {
            // Quit driver
            Driver.QuitDriver();
        }
    }
}

