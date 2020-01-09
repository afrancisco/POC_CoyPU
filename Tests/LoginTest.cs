using Coypu;
using NUnit.Framework;
using POC_CoyPU.Common;
using POC_CoyPU.Page;

namespace POC_CoyPU.Tests
{

    [TestFixture]
    public class LoginTest :BaseTest
    {
        private LoginPage _login;
        private WorkbenchPage _workbench;

        [SetUp]
        public void Start()
        {
            _login = new LoginPage(Browser);
            _workbench = new WorkbenchPage(Browser);

        }
        [TestCase("leao","Matheus.leao", "Teste102030", "",Category ="BR")]
        public void ShouldSeeAlertMessage() {
            _login.FillNovajusFields("","", "");
            Assert.AreNotEqual("", _login.AlertOnePassRequiredUser(), "User error message does not displayed");
            Assert.AreNotEqual("", _login.AlertOnePassRequiredPassword(), "Password error mensage does not displayed");

        }

        [Test]
        [Category("Login")]
        [Category("SmokeTest")]
        public void ShouldSeeUserNameWithLegalOneLogin()
        {
            _login.FillNovajusFields("leao", "QAUSER3", "123456");
            Assert.AreEqual("QAUSER3", Browser.FindCss(".user-name-popover", Options.Invisible).InnerHTML);
        }

        [Test]
        [Category("Login")]
        [Category("SmokeTest")]
        public void ShouldSeeWorkbanchOnePass()
        {
            _login.FillOnePassFields( "matheus.leao", "Teste123123");
            Assert.AreEqual("Legal One - Workbench",Browser.Title);
        }

        [Test]
        [Category("Login")]
        [Category("SmokeTest")]
        public void ShouldValidateRequiredFieldsInOnePassLogin()
        {
            _login.FillOnePassFields("", "");
            Assert.AreNotEqual("", _login.AlertOnePassRequiredUser(),"User error message does not displayed") ;
            Assert.AreNotEqual("", _login.AlertOnePassRequiredPassword(), "Password error mensage does not displayed");
        }

        [Test]
        [Category("Login")]
        [Category("SmokeTest")]
        public void ShouldValidateWrongUserInOnePass()
        {
            _login.FillOnePassFields("matheus.leao", "Teste1545");
            Assert.AreNotEqual("", _login.AlertOnePassWrongUser());
        }

    }
}
