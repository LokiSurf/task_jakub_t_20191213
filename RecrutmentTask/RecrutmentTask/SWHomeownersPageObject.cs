using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutmentTask
{
    class SWHomeownersPageObject
    {
        public SWHomeownersPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);  //this - points on the concrete page object with below items
        }

        [FindsBy(How = How.Id, Using = "segmentSelectorHeaderText")]
        public IWebElement Homeowners { get; set; }
        [FindsBy(How = How.LinkText, Using = "For Homeowners")]
        public IWebElement ForHomeowners { get; set; }
        [FindsBy(How = How.Id, Using = "SimpleSearchForm_SearchTerm")]
        public IWebElement SearchBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//ul[contains(@class, 'color autoSuggestDivNestedList')]/li[1]/a[1]")]
        public IWebElement TuberoseColor { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#color-info--color-details-tab")]
        public IWebElement SearchNameProduct { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#color-info--color-details-tab > span")]
        public IWebElement DetailsBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".actions__view-family-colors.ng-binding.track-on-click")]
        public IWebElement AllRedPaintColors { get; set; }
        [FindsBy(How = How.ClassName, Using = "input-field")]
        public IWebElement ColorSearchBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='color-info-color-details-panel']/div/div[2]/div[2]/span")]
        public IWebElement HexText { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#container_3074457345618276823 > div > div > div.ng-scope > div > div > sw-color-wall > div.color-wall > div.color-wall__search.ng-scope > sw-color-search-form > div > sw-color-search-page > div > ul > li > sw-color-grid-item > div > div > a")]
        public IWebElement Colorhref { get; set; }  //could be xPath a[@class='ng-scope']
        [FindsBy(How = How.XPath, Using = "//*[@class='color-hex ng-binding']/span[@class='label']/..")]
        public IWebElement HexValue { get; set; }


        public void SelectHomeowners() /// you can also do this  public void SelectHomeowners() =>  Homeowners.Clicks();
        {

            Homeowners.Clicks();

        }

        public void SelectForHomeowners() 
        {
            
            ForHomeowners.Clicks();

        }

        public void SelectSearchBoxAndSendValue(string phrase) 
        {
                        
            SearchBox.EnterText(phrase);
            
        }

        public void SelectTuberoseColor() 
        {
            
            TuberoseColor.Clicks();

        }

        public void SelectDetailsBtn() 
        {
          
            DetailsBtn.Clicks();

        }

        public void SelectAllRedPaintColors() 
        {
            
            AllRedPaintColors.Clicks();

        }

        public void SelectColorSearchBoxAndSendValue(string color) 
        {
           
            ColorSearchBox.EnterText(color);
            ColorSearchBox.Submit();
            
        }

        public void GetHexValue() 
        {
           
            HexValue.GetText();
            
        }

    }
    
}
