using OpenQA.Selenium;

namespace _NET_UI_Automation_6.pages
{
	public class FrontendTestingPage : BasePage
	{
		public IList<IWebElement> cards => driver.FindElements(By.CssSelector(".card"));
	}
}

