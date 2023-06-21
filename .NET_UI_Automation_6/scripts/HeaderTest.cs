using _NET_UI_Automation_6.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
	[TestFixture]
	public class HeaderTest : BaseTest
	{

		[SetUp]
		public void SetPage()
		{
			basePage = new BasePage();
		}

		[Test] // Like @Test annotation from TestNG
		public void ValidateLogo()
		{
			Thread.Sleep(1000);
			// Assertions
			Assert.That(basePage.logo.Displayed);
        }


		[Test]
		public void ValidateThePracticesDropdown()
		{
			

            string[] expectedTexts = { "Frontend Testing", "Backend Testing", "Java Exercises", "JS Exercises", "Mock Interviews" };

            Assert.That(basePage.practicesDropdown.Displayed);
			Assert.That(basePage.practicesDropdown.Text, Is.EqualTo("Practices"));


			Actions actions = new Actions(driver);
			actions.MoveToElement(basePage.practicesDropdown).Perform();

			for(int i = 0; i < basePage.dropdownOptions.Count; i++)
			{
				Assert.That(basePage.dropdownOptions[i].Text, Is.EqualTo(expectedTexts[i]));
			}
        }


	}
}

