using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [NonParallelizable]
        public void Test1()
        { 
         // Assert.AreEqual(driver.Title, "MarketProminence Authorization");
            Assert.Pass();
        }
    }
}