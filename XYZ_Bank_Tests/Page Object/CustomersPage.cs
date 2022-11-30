using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Page_Object
{
    public class CustomersPage : BasePage
    {
        private static WebDriverWait wait;
        public CustomersPage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
        }

        private IWebElement BtnCustomers => wait.Until(e => e.FindElement(By.XPath("//button[@ng-click='showCust()']")));
        public void ClickCustomers() => BtnCustomers.Click();

    }
}
