using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace WebSiteTest.Forms;

public class FilterForm : Form
{
    private static IButton SomeFilterButton(string filterName) =>
        ElementFactory.GetButton(By.XPath($"//button[contains(text(), '{filterName}')]"), "Filter button");

    private static ICheckBox LanguageCheckBox(string language) =>
        ElementFactory.GetCheckBox(By.XPath($"//label[contains(text(), '{language}')]"),
            "Some language checkbox");
    
    public FilterForm() : base(By.XPath("//div[contains(@class, 'col-lg-4')]"), "Forms with filter")
    {
    }

    public void ClickSomeFilterButton(string filterName)
    {
        SomeFilterButton(filterName).ClickAndWait();
    }
    
    public void ChooseSomeLanguage(string language)
    {
        LanguageCheckBox(language).Click();
    }
}