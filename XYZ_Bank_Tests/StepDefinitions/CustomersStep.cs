
using SpecFlowProject_XYZ_Bank.Steps;
using Page_Object;

namespace SpecFlowProject_XYZ_Bank.StepDefinitions
{
    [Binding]
    public class CustomersStep : BaseStep

    {
        private CustomersPage customersPage;
        [Given(@"clicks Customers button")]
        public void GivenClicksCustomersButton()
        {
            customersPage = new CustomersPage(driver);
            customersPage.ClickCustomers();
        }
    }
}
