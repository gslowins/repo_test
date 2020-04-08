Scenario Outline: Successful Login with Valid Credentials
 Given User is at the Home Page
 And Navigate to LogIn Page
 When User enter <username> and <password>
 And Click on the LogIn button
 Then Successful LogIN message should display
Examples:
| username   | password |
| testuser_1 | Test@123 |
| testuser_2 | Test@153 |using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
 
namespace SpecFlowDemo.Steps
{
    [Binding]
    public class LogIn_Steps
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://jobs.ubs.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=25008&siteid=5012&PageType=searchResults&SearchType=linkquery&LinkID=6017#keyWordSearch=&locationSearch=";
        }
 
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[3]/div/div[2]/a[7]/span")).Click();
        }
 
        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            driver.FindElement(By.Id("loginFieldMobile")).SendKeys(username);
            driver.FindElement(By.Id("passwordMobile")).SendKeys(password);
        }
 
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[6]/div[5]/div[2]/div[2]/div[2]/div/div/form/button/span[1]")).Click();
        }
 
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
 
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
        }
 
        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
