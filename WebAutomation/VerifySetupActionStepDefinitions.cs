using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebAutomation.Pages;
using Xunit;


namespace WebAutomation
{
    [Binding]
    [CollectionDefinition("SpecFlowNonParallelizableFeatures", DisableParallelization = true)]
    public class VerifySetupActionStepDefinitions
    {
        
    
        static  Webutility_v1 wb= new Webutility_v1();  

        static IWebDriver driver = new ChromeDriver();
        static Selenium obj = new Selenium(driver);

        [Given(@"Open browser")]
        public void GivenOpenBrowser()
        {          
            driver.Navigate().GoToUrl("https://mpwebdemo.mhkdevsandbox.com");
            Thread.Sleep(3000);
             
        }

        [Given(@"go to  https://mpwebdemo.mhkdevsandbox.com")]
        public void GivenGoToHttpsMpwebdemo_Mhkdevsandbox_Com()
        {
            Console.WriteLine("hey");         

        }

        [Then(@"User should be redirected to login screen")]
        public void ThenUserShouldBeRedirectedToLoginScreen()
        {
            Console.WriteLine("heeeee");
        }

        [When(@"UserName ""([^""]*)""  Password ""([^""]*)""")]
        public void WhenUserNamePassword(string p2, string p1)
        {
            
            wb.CreateExcelSheets();
            //1  ab.values();
            wb.dict.TryGetValue("user_xpath", out var xpath_user);
            wb.dict.TryGetValue("user_id",out var userId);
            wb.dict.TryGetValue("password_xpath", out var xpath_password);
            wb.dict.TryGetValue("password", out var pass);

            obj.Textvalues(xpath_user,userId);
            obj.Textvalues(xpath_password,pass);
            wb.dict.TryGetValue("Login_Button_xpath", out var xpath_button);
            obj.buttonclick(xpath_button);        
        }


        [When(@"click on the login button")]
        public void WhenClickOnTheLoginButton()
        {
            Thread.Sleep(5000);
            Console.WriteLine("heeeee");
        }

        [Then(@"the user should be logged in to MP Web")]
        public void ThenTheUserShouldBeLoggedInToMPWeb()
        {   
            string x = "/html/body/div/div/div/div/div/div[2]/form/fieldset/div[2]/button[2]";
            obj.buttonclick(x);
        }

        [Given(@"User is on Mpweb welcome screen")]
        public void GivenUserIsOnMpwebWelcomeScreen()
        {
            Console.WriteLine("heeeee");
        }

        [Given(@"Navigate to Windows dropdown")]
        public void GivenNavigateToWindowsDropdown()
        {
            Thread.Sleep(3000);
            wb.dict.TryGetValue("navbar_xpath", out var xpath_navbarclick);
            obj.buttonclick(xpath_navbarclick); 
        }

        [Given(@"Open the Windows dropdown")]
        public void GivenOpenTheWindowsDropdown()
        {
            wb.dict.TryGetValue("navbarvalue_xpath", out var xpath_navbar);
            obj.buttonclick(xpath_navbar);
            Thread.Sleep(10000);
        }

        [When(@"Click on Setup in Windows dropdown")]
        public void WhenClickOnSetupInWindowsDropdown()
        {
            Console.WriteLine("heyy");
        }

        [Then(@"user should be redirected to MP Web Setup Action screen")]
        public void ThenUserShouldBeRedirectedToMPWebSetupActionScreen()
        {
            Console.WriteLine("heyy");
        }

        [Given(@"I am on MP Web Setup Action screen")]
        public void GivenIAmOnMPWebSetupActionScreen()
        {
            Console.WriteLine("heyy");
        }

        [Given(@"Navigate to Setup List dropdown")]
        public void GivenNavigateToSetupListDropdown()
        {
            Console.WriteLine("heyy");
        }

        [When(@"Select any value from the setup List")]
        public void WhenSelectAnyValueFromTheSetupList()
        {
            Console.WriteLine("heyy");
        }

        [Then(@"User should be redirected to Selected setup list")]
        public void ThenUserShouldBeRedirectedToSelectedSetupList()
        {
            Console.WriteLine("heyy");
        }

      

        [Given(@"Click on Add button")]
        public void WhenClickOnAddButton()
        {
           wb.dict.TryGetValue("Add_Button_xpath",out var xpath_addbutton);
           obj.ADD(xpath_addbutton);
        }

        [Given(@"Navigate to Program dropdown")]
        public void WhenNavigateToProgramDropdown()
        {
            wb.dict.TryGetValue("Program_xpath", out var xpath_picklist);
            wb.dict.TryGetValue("Program", out var value);
            obj.Dropdown(xpath_picklist, value);
        }

        
        [Given(@"Navigate to Primary dropdown")]
        public void WhenNavigateToPrimaryDropdown()
        {
             
            wb.dict.TryGetValue("Primary", out var value);
            wb.dict.TryGetValue("primary_xpath", out var xpath_primary);
            obj.Textvalues(xpath_primary, value);
           
        }

        [Given(@"Navigate to Secondary text field")]
        public void WhenNavigateToSecondaryTextField()
        {
           
            wb.dict.TryGetValue("Secondary", out var value);
            wb.dict.TryGetValue("secondary_xpath", out var x_secondary);
            obj.Textvalues(x_secondary,value);
        }

        [Given(@"Navigate to Site dropdown")]
        public void WhenNavigateToSiteDropdown()
        {
            wb.dict.TryGetValue("site_xpath", out var xpath_site);
            wb.dict.TryGetValue("Site", out var value);
            obj.Dropdown(xpath_site, value);
            // obj.selectsite();
        }

        [Given(@"Navigate to Product dropdown")]
        public void WhenNavigateToProductDropdown()
        {
           Console.WriteLine("hey");
           // obj.selectproduct();
        }

        [Given(@"Click on Save button")]
        public void WhenClickOnSaveButton()
        {     
            wb.dict.TryGetValue("Save_button_xpath", out var save);
            obj.buttonclick(save);
            Thread.Sleep(5000);
        }      

        [Given(@"Created record selected by default")]
        public void GivenCreatedRecordSelectedByDefault()
        {
            Console.WriteLine("Done");
        }

        [Given(@"Change any value")]
        public void GivenChangeAnyValue()
        {
            Console.WriteLine("Done");             
        }

        [When(@"Click on Save")]
        public void WhenClickOnSave()
        {
            Console.WriteLine("Done");
        }

        [Then(@"Value should be reset to last saved values")]
        public void ThenValueShouldBeResetToLastSavedValues()
        {
            wb.dict.TryGetValue("secondary_xpath", out var xpath_secondary);
            wb.dict.TryGetValue("Save_button_xpath", out var save);
            obj.Textvalues(xpath_secondary, "  Edited");
            Thread.Sleep(5000);//save 5
            obj.buttonclick(save);
            Thread.Sleep(5000);
        }

        [Given(@"Created record selected by defaults")]
        public void GivenCreatedRecordSelectedByDefaults()
        {     
            wb.dict.TryGetValue("Cancel_xpath", out var xpath_cancel);
            wb.dict.TryGetValue("secondary_xpath", out var xpath_secondary);
            obj.editandcancel(xpath_secondary);
            obj.buttonclick(xpath_cancel);
            Thread.Sleep(5000);
        }

        [Given(@"Select the value from spreadsheet")]
        public void GivenSelectTheValueFromSpreadsheet()
        {
            Console.WriteLine("heyy");          
        }
    }
}
