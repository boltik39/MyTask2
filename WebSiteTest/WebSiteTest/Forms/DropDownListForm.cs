using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace WebSiteTest.Forms;

public class DropDownListForm : Form
{
    private static IButton SomeFilter(string filterPoint) =>
        ElementFactory.GetButton(By.XPath($"//a[text()='{filterPoint}']"), "Some Filter");
    
    public DropDownListForm() : base(By.XPath(""), "List With different filters")
    {
    }

    public void ClickOnFilterPoint(string filterPoint)
    {
        SomeFilter(filterPoint).ClickAndWait();
    }
}