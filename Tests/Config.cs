using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Config
    {
        public BrowserSession browser;
        public SessionConfiguration configs;

        [SetUp]
        public void Setup()
        {
            configs = new SessionConfiguration
            {
                AppHost = "https://login.kanbanleando.dev.azure.novajus.com.br",
                SSL = true,
                Browser = Coypu.Drivers.Browser.Chrome,
                Driver = typeof(SeleniumWebDriver)
            };
            browser = new BrowserSession(configs);
            browser.MaximiseWindow();

        }
        [TearDown]
        public void Dispose()
        {
            browser.Dispose();

        }

        [Test]
        public void ShouldBeHaveTitle()
        {
            browser.Visit("/conta/login");
            Assert.AreEqual("Legal One", browser.Title);
        }

     
    }
}