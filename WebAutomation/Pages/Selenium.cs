using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Data;

namespace WebAutomation.Pages
{
    public class Selenium
    {
        public IWebDriver WebDriver { get; }
         public Selenium(IWebDriver driver)
         {
            WebDriver = driver;
         }
         public void Textvalues(string username12,string data)
         { 
            IWebElement w=WebDriver.FindElement(By.XPath(username12));
            w.SendKeys(data);
         }
        public void Dropdown(string dropc1lick,string data)
        {
           IWebElement w = WebDriver.FindElement(By.XPath(dropc1lick));
           w.Click();
           Thread.Sleep(5000);
           w.FindElement(By.XPath(data)).Click();
        }
      
        public void  buttonclick(string button)
        {
            IWebElement w = WebDriver.FindElement(By.XPath(button));
            w.Click();
            Thread.Sleep(1000); 
        }
         public void ADD(string x)
         {
            IWebElement w = WebDriver.FindElement(By.XPath(x));
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click();", w);
            Thread.Sleep(5000);
         }
    
         public void editandcancel(string xpath)
        {
          IWebElement w = WebDriver.FindElement(By.XPath(xpath));         
          WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
          w.Clear();
          w.SendKeys("Loading");
          WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));           
         }

    


    }
}
