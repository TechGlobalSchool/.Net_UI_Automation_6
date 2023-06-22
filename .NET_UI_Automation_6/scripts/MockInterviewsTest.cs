using NUnit.Framework;
using _NET_UI_Automation_6.pages;
using OpenQA.Selenium;

namespace _NET_UI_Automation_6.scripts
{
	public class MockInterviewsTest : BaseTest
	{
		[SetUp]
		public void SetPage()
		{
			mockInterviewsPage = new MockInterviewsPage();

            actions.MoveToElement(mockInterviewsPage.practicesDropdown).Perform();
            mockInterviewsPage.dropdownOptions[4].Click();
        }

		[Test]
		public void ValidateTheHeader()
		{
			Assert.That(mockInterviewsPage.header.Text, Is.EqualTo("Designed for TechGlobal Students"));
		}

		[Test]
		[TestCase("john", "1234")]
        [TestCase("techglobal", "2020")]
        [TestCase("okan", "1234test")]
        public void ValidateLoginFormErrorMessage(string username, string password)
		{
			mockInterviewsPage.usernameInputBox.SendKeys(username);
			//mockInterviewsPage.passwordInputBox.SendKeys("1234" + Keys.Enter);

			mockInterviewsPage.passwordInputBox.SendKeys(password);
			mockInterviewsPage.loginButton.Click();

			Assert.That(mockInterviewsPage.errorMessage.Text, Is.EqualTo("Email or Password does not match!"));
		}


	}
}

