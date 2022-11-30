
using Page_Object;
using SpecFlowProject_XYZ_Bank.Steps;

namespace SpecFlowProject_XYZ_Bank.StepDefinitions
{
    [Binding]
    public class SortingStep : BaseStep
    {
        private SortingPage sortingPage;
        List<string> actualListOfPostCodes = new List<string>();
        List<string> expectedListOfPostCodes = new List<string>();

        [When(@"clicks on the post code header")]
        public void WhenClicksOnThePostCodeHeader()
        {
            sortingPage = new SortingPage(driver);
            sortingPage.ClickPostCode();
            expectedListOfPostCodes = sortingPage.GetPostCodes();
            expectedListOfPostCodes.Sort();
            sortingPage.ClickPostCode();
            actualListOfPostCodes = sortingPage.GetPostCodes();
        }

        [Then(@"the customers are sorted by Post Code")]

        public void ThenTheCustomersAreSortedByPostCode()
        {
            try
            {
                Assert.AreEqual(actualListOfPostCodes, expectedListOfPostCodes);
            }
            catch (AssertFailedException err)
            {
                Console.WriteLine(err.Message);
            }
            
        }
    }
}
