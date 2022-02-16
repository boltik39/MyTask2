using NUnit.Framework;
using WebSiteTest.Forms;
using WebSiteTest.Utils;

namespace WebSiteTest;

public class Tests : BaseTest
{
    [Test]
    public void Test1()
    {
        var vacancyPage = new VacancyPage();
        Assert.IsTrue(vacancyPage.State.WaitForDisplayed(), "Start page was not opened");
        
        vacancyPage.AcceptCookie();
        vacancyPage.ClickSomeFilterButton(ConfigWork.GetFromTestData("AllDepartment"));
        vacancyPage.ClickOnSomeFilterPoint(ConfigWork.GetFromTestData("AppDev"));
        vacancyPage.ClickSomeFilterButton(ConfigWork.GetFromTestData("AllLang"));
        vacancyPage.ChooseCorrectLanguage(ConfigWork.GetFromTestData("Language"));
        
        Assert.IsTrue(vacancyPage.GetAmountOfVacancy() == int.Parse(ConfigWork.GetFromTestData("CorrectAmountOfVacancy")), "Amount of vacancy is not correct");
    }
}