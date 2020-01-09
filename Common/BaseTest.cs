using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using System;

namespace POC_CoyPU.Common
{
    public class BaseTest
    {
        protected BrowserSession Browser;
        protected SessionConfiguration Configs;

        [SetUp]
        public void Setup()
        {
            Configs = new SessionConfiguration
            {
                AppHost = "https://login.kanbanleando.dev.azure.novajus.com.br",
                SSL = true,
                Browser = Coypu.Drivers.Browser.Chrome,
                Driver = typeof(SeleniumWebDriver),
                Timeout = TimeSpan.FromSeconds(10)
            };
            Browser = new BrowserSession(Configs);
            Browser.MaximiseWindow();

        }
        [TearDown]
        public void Dispose()
        {
            Browser.Dispose();
        }
    }
}
