using _NET_UI_Automation_6.utils;
using _NET_UI_Automation_6.scripts;
using OpenQA.Selenium;

namespace _NET_UI_Automation_6.pages
{
	public class BasePage : BaseTest
	{
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement practicesDropdown => driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> dropdownOptions => driver.FindElements(By.CssSelector("#dropdown-menu a"));

        public IWebElement addressText => driver.FindElement(By.XPath("(//div[@class='has-text-centered']//p)[1]"));
        public IList<IWebElement> socialMediaIcons => driver.FindElements(By.CssSelector(".Footer_socials__7h4n1 a"));

        /*
        public void ClickOnPracticesDropdownOption(string text)
        {
            actions.MoveToElement(practicesDropdown).Perform();

            foreach(IWebElement option in dropdownOptions){
                if (option.Text.Equals(text))
                {
                    option.Click();
                    break;
                }
            }
        }
        */
    }
}

