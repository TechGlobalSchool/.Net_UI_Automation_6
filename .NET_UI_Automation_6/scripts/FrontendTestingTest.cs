using _NET_UI_Automation_6.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
    public class FrontendTestingTest : BaseTest
    {
        [SetUp]
        public void SetPage()
        {
            basePage = new BasePage();
            frontendTestingPage = new FrontendTestingPage();
        }

        [Test]
        public void ValidateFrontendTestingCards()
        {
            actions.MoveToElement(basePage.practicesDropdown).Perform();
            basePage.dropdownOptions[0].Click();

            Assert.That(frontendTestingPage.cards.Count(), Is.EqualTo(25));

            foreach (IWebElement element in frontendTestingPage.cards)
            {
                Assert.IsNotEmpty(element.Text);
            }
        }
    }
}

