using OpenQA.Selenium;

namespace _NET_UI_Automation_6.pages
{
	public class MockInterviewsPage : BasePage
	{
		public IWebElement header => driver.FindElement(By.TagName("h2"));
		public IWebElement usernameInputBox => driver.FindElement(By.CssSelector("input[type='email']"));
        public IWebElement passwordInputBox => driver.FindElement(By.CssSelector("input[type='password']"));
		public IWebElement loginButton => driver.FindElement(By.CssSelector("button[type='submit']"));
		public IWebElement errorMessage => driver.FindElement(By.CssSelector("div[class*='errorMessage']>p"));
    }
}

