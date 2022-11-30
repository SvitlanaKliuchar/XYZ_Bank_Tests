
using Page_Object;
using SpecFlowProject_XYZ_Bank.Steps;

namespace SpecFlowProject_XYZ_Bank.StepDefinitions
{
    [Binding]

    public class HomePageStep : BaseStep
    {
        private HomePage homePage;
        [Given(@"the user opens the website")]
        public void GivenTheUserOpensTheWebsite()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/";
            homePage = new HomePage(driver);

        }

        [Given(@"clicks Bank Manager Login button")]
        public void GivenClicksBankManagerLoginButton()
        {
            homePage.ClickHome();
        }
    }
}
