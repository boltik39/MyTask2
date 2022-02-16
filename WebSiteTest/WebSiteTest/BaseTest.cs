using Aquality.Selenium.Browsers;
using NUnit.Framework;
using WebSiteTest.Utils;

namespace WebSiteTest;

public class BaseTest
{
    [SetUp]
    public void Setup()
    {
        AqualityServices.Browser.GoTo(ConfigWork.GetFromConfig("START_URL"));
        AqualityServices.Browser.Maximize();
    }

    [TearDown]
    public void FinishWork()
    {
        if (AqualityServices.Browser.IsStarted)
        {
            AqualityServices.Browser.Quit();
        }
    }
}