using Coypu;

namespace POC_CoyPU.Page
{
    public class LoginPage
    {
        private LoginOptionPage loginOption;

        private readonly BrowserSession _browser;
        public string loginUrlNovajusPath;
        public string loginUrlOnePassPath;
        public string novajusUserInput;
        public string novajusPasswordInput;
        public string userOnePassInput;
        public string tenantInput;
        public string passwordOnePassInput;
        public string onePassLoginButton;
        public string novajusLoginButton;
        public LoginPage(BrowserSession browser)
        {
            loginOption = new LoginOptionPage(browser);

            _browser = browser;
            tenantInput = "Escritorio";
            novajusUserInput = "Usuario";
            novajusPasswordInput = "Senha";
            novajusLoginButton = "entrar";

            userOnePassInput = "Username";
            passwordOnePassInput = "Password";
            onePassLoginButton = "SignIn";
        }

        public void FillNovajusFields(string tenantNovajus, string userNovajus, string passwordNovajus)
        {
            loginOption.Goto(loginOption.loginUrlNovajusPath);
            _browser.ClickButton(loginOption.novajusAccessButton);
            _browser.FillIn(tenantInput).With(tenantNovajus);
            _browser.FillIn(novajusUserInput).With(userNovajus);
            _browser.FillIn(novajusPasswordInput).With(passwordNovajus);
            _browser.ClickButton(novajusLoginButton);


        }

        public void FillOnePassFields(string userOnePass, string passwordOnePass)
        {
            loginOption.Goto(loginOption.loginUrlOnePassPath);

            _browser.ClickButton(loginOption.onePassAccessButton);
            _browser.FillIn(userOnePassInput).With(userOnePass);
            _browser.FillIn(passwordOnePassInput).With(passwordOnePass);
            _browser.ClickButton(onePassLoginButton);

        }

        public string AlertOnePassRequiredUser() {
            return _browser.FindId("Username-error").Text;
        }
        public string AlertOnePassRequiredPassword() {
            return _browser.FindId("Password-error").Text;
        }
        public string AlertOnePassWrongUser() {
           return  _browser.FindCss("span[role='alert']").Text;
        }
        public string AlertNovaJusLogin() {
            return _browser.FindCss(".validation-summary-errors").Text;
        }
       

    }
}
