using Coypu;
using NUnit.Framework;
using POC_CoyPU.Common;

namespace POC_CoyPU.Page
{
    public class WorkbenchPage:BaseTest
    {
        private LoginPage _loginPage;
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Browser);
            _loginPage.FillNovajusFields("leao", "QAUSER3", "123456");

        }
        public WorkbenchPage(BrowserSession browser)
        {
        }
    }
}
