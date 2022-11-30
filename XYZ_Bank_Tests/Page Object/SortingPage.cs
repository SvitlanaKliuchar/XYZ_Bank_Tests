using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Page_Object
{
    public class SortingPage : BasePage
    {
        private static WebDriverWait wait;
        public SortingPage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
        }

        private IWebElement BtnPostCode => wait.Until(e => e.FindElement(By.XPath("//tr/td[3]")));
        private List<IWebElement> PostCodeElements => wait.Until(e => e.FindElements(By.XPath("//tr/td[3][@class='ng-binding']")).ToList<IWebElement>());

        public void ClickPostCode() => BtnPostCode.Click();
        public List<string> GetPostCodes() => PostCodeElements.Select(el => el.Text).ToList<string>();
    }

}