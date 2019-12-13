using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecrutmentTask 
{
    class Program
    {



        static void Main(string[] args)
        {
        }

        
        [SetUp]
        public void SWInitialize()
        {
            

            PropertiesCollection.driver = new ChromeDriver();
            

            PropertiesCollection.driver.Navigate().GoToUrl("https://www.sherwin-williams.com/");
            Console.WriteLine("Open browser");
        }

        [Test]
        public void SWRegistration()
        {
            Console.WriteLine("Test just has been started");
            SWHomePageObject sWHomePage = new SWHomePageObject(); 
            SWHomeownersPageObject sWHomeowners = new SWHomeownersPageObject();

            string privacySettings = "#ensAllow > div:nth-child(1)";
            AsyncWaitMethods.WaitByCssSelector(10, privacySettings);
            sWHomePage.SelectPrivacySettings();
            Console.WriteLine("Selected privacy policy");

            string forHomeowners = "For Homeowners";
            sWHomePage.SelectShopOurProducts();
            AsyncWaitMethods.WaitByLinkText(10, forHomeowners);
            Console.WriteLine("Selected Shop Our Products");

            string searchBoxAndSendValue = "SimpleSearchForm_SearchTerm";
            sWHomeowners.SelectForHomeowners();
            AsyncWaitMethods.WaitById(10, searchBoxAndSendValue);
            Console.WriteLine("Selected For Homeowners");

            string tuberoseColor = "//ul[contains(@class, 'color autoSuggestDivNestedList')]/li[1]/a[1]";
            sWHomeowners.SelectSearchBoxAndSendValue("tuberose paint");
            AsyncWaitMethods.WaitByXPath(10, tuberoseColor);
            Console.WriteLine("Selected search box and sent value 'tuberose paint' ");

            sWHomeowners.SelectTuberoseColor();
            Console.WriteLine("Selected value 'tuberose paint' from tooltip");

            string actualUrl = PropertiesCollection.driver.Url;
                               
            try
            {
                Assert.IsTrue(actualUrl.Contains(ExpectedResults.expectedUrl));
                Console.WriteLine("I am on the right page");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("This adres " + actualUrl + " does not contain " + ExpectedResults.expectedUrl + " You are on wrong page ");
                
            }
           
                                   
            string productCode = "//*[@id='container_3074457345618276802']/div/div[3]/div[1]/div/div/sw-color-details-viewer/div/div/div[1]/h1/span[1]";
            AsyncWaitMethods.WaitByXPath(10, productCode);

            try
            {
                Assert.IsTrue(PropertiesCollection.driver.FindElement(By.XPath(productCode)).Displayed);
                Console.WriteLine("Element ProductCode is displayed");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("Element ProductCode is not dispalyed");
            }
            
           

            string productName = "//*[@id='container_3074457345618276802']/div/div[3]/div[1]/div/div/sw-color-details-viewer/div/div/div[1]/h1/span[3]";
            AsyncWaitMethods.WaitByXPath(10, productName);

            try
            {
                Assert.IsTrue(PropertiesCollection.driver.FindElement(By.XPath(productName)).Displayed);
                Console.WriteLine("Element ProductName is displayed");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("Element ProductName is not dispalyed");
            }

            
          
            string details = "button#color-info--color-details-tab";
            AsyncWaitMethods.WaitByCssSelector(10, details);
            sWHomeowners.SelectDetailsBtn();
            Console.WriteLine("Selected details tab");

            string hexVal = "//*[@class='color-hex ng-binding']/span[@class='label']/..";
            AsyncWaitMethods.WaitByXPath(10, hexVal);
   
            string actualHexValue = sWHomeowners.HexValue.Text;
               
            try
            {
                Assert.AreEqual(ExpectedResults.excepteHexValue, actualHexValue);
                Console.WriteLine("Hex value is correct");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("Actual value " + actualHexValue + " is different than " + ExpectedResults.excepteHexValue);

            }
            

            string ColorSearchBoxAndSendValue = "input-field";
            sWHomeowners.SelectAllRedPaintColors();
            AsyncWaitMethods.WaitByClassName(10, ColorSearchBoxAndSendValue);
            Console.WriteLine("Selected 'View All Red Paint Color' link");

            sWHomeowners.SelectColorSearchBoxAndSendValue("tuberose");
            string tubeColor = "#container_3074457345618276823 > div > div > div.ng-scope > div > div > sw-color-wall > div.color-wall > div.color-wall__search.ng-scope > sw-color-search-form > div > sw-color-search-page > div > ul > li > sw-color-grid-item > div > div > a";
            AsyncWaitMethods.WaitByCssSelector(10, tubeColor );  
            Console.WriteLine("Selected color searchBox and send value 'tuberose'");

            string hrefurl = sWHomeowners.Colorhref.GetAttribute("href");
            TabMethod.OpenNewTab(hrefurl);
            Console.WriteLine("Opened new tab with the new adress ");

            string lastProductCode = "//*[@id='container_3074457345618276802']/div/div[3]/div[1]/div/div/sw-color-details-viewer/div/div/div[1]/h1/span[1]";
            AsyncWaitMethods.WaitByXPath(10, lastProductCode);

            try
            {
                Assert.IsTrue(PropertiesCollection.driver.FindElement(By.XPath(lastProductCode)).Displayed);
                Console.WriteLine("Element LastProductCode is displayed");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("Element LastProductCode is not dispalyed");
            }

            

            string lastProductName = "//*[@id='container_3074457345618276802']/div/div[3]/div[1]/div/div/sw-color-details-viewer/div/div/div[1]/h1/span[3]";
            AsyncWaitMethods.WaitByXPath(10, lastProductName);
            try
            {
                Assert.IsTrue(PropertiesCollection.driver.FindElement(By.XPath(lastProductName)).Displayed);
                Console.WriteLine("Element LastProductName is displayed");
            }
            catch (AssertionException e)
            {
                Console.WriteLine("Element LastProductNamee is not dispalyed");
            }

            

            Console.WriteLine("Test just has been finished");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close browser");
        }
    }
}
