using Coypu;
using POC_CoyPU.Common;

namespace POC_CoyPU.Page
{
    public class LoginOptionPage:BaseTest
    {
        public string loginUrlNovajusPath;
        public string loginUrlOnePassPath;
        public string novajusAccessButton;
        public string onePassAccessButton;

        public LoginOptionPage(BrowserSession browser)
        {
            Browser = browser;
            loginUrlNovajusPath = "/conta/login";
            loginUrlOnePassPath = "http://login.novajus.com.br";
            novajusAccessButton = "btn-login-legalOne";
            onePassAccessButton = "btn-login-onepass";

        }
        public void Goto(string url)
        {
            Browser.Visit(url);
        }

     

    }
}
