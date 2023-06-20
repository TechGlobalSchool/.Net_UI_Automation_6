using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
	[TestFixture]
	public class HeaderTest
	{
		public static IWebDriver driver;

        // Before - set up actions
        [SetUp]
		public void SetUp()
		{
            // Set up driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            // Navigate to url
            driver.Navigate().GoToUrl("https://techglobal-training.com/");
        }

		// After - teardown actions
		[TearDown]
		public void TearDown()
		{
            // Quit driver
            driver.Quit();
        }

		[Test] // Like @Test annotation from TestNG
		public void ValidateLogo()
		{
			// Locate web elements using 8 different locators
			IWebElement logo = driver.FindElement(By.Id("logo"));

			// Assertions
			Assert.That(logo.Displayed);
        }


		[Test]
		public void ValidateThePracticesDropdown()
		{
			IWebElement practicesDropdown = driver.FindElement(By.Id("dropdown-button"));
			IList<IWebElement> dropdownOptions = driver.FindElements(By.CssSelector("#dropdown-menu a"));

            string[] expectedTexts = { "Frontend Testing", "Backend Testing", "Java Exercises", "JS Exercises", "Mock Interviews" };

            Assert.That(practicesDropdown.Displayed);
			Assert.That(practicesDropdown.Text, Is.EqualTo("Practices"));


			Actions actions = new Actions(driver);
			actions.MoveToElement(practicesDropdown).Perform();

			for(int i = 0; i < dropdownOptions.Count; i++)
			{
				Assert.That(dropdownOptions[i].Text, Is.EqualTo(expectedTexts[i]));
			}
        }


	}
}

