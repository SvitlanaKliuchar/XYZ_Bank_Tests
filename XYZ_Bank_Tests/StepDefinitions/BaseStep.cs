using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SpecFlowProject_XYZ_Bank.Steps
{
    [Binding]
    public class BaseStep
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}