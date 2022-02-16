using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace WebSiteTest.Forms;

public class CookiesForm : Form
{
    private static IButton AcceptCookieButton =>
        ElementFactory.GetButton(By.XPath("//div[contains(@id, 'cookiescript_accept')]"), "Accept cookie button");
    
    public CookiesForm() : base(By.XPath("//div[contains(@id, 'cookiescript_injected')]"), "Cookie Form")
    {
    }

    public void ClickOnAcceptButton()
    {
        AcceptCookieButton.ClickAndWait();
    }
}