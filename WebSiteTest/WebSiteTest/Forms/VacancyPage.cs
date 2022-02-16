using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace WebSiteTest.Forms;

public class VacancyPage : Form
{
    private readonly FilterForm _filterForm = new FilterForm();
    
    private readonly DropDownListForm _listWithFiltersPoint = new DropDownListForm();

    private readonly CookiesForm _cookiesForm = new CookiesForm();
    
    public VacancyPage() : base(By.XPath("//div[contains(@class, 'col-lg-4')]"), "Vacancy page")
    {
    }

    public void ClickSomeFilterButton(string filterName)
    {
        _filterForm.ClickSomeFilterButton(filterName);
    }

    public void ClickOnSomeFilterPoint(string filterPoint)
    {
        _listWithFiltersPoint.ClickOnFilterPoint(filterPoint);
    }
    
    public void ChooseCorrectLanguage(string language)
    {
        _filterForm.ChooseSomeLanguage(language);
    }

    public int GetAmountOfVacancy()
    {
        return ElementFactory.FindElements<ILabel>(By.XPath("//a[contains(@class, 'card-no-hover')]")).Count;
    }

    public void AcceptCookie()
    {
        _cookiesForm.ClickOnAcceptButton();
    }
}