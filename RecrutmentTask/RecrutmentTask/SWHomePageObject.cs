using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutmentTask
{
    class SWHomePageObject
    {
        public SWHomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);  
        }

        [FindsBy(How = How.CssSelector, Using = "#ensAllow > div:nth-child(1)")]
        public IWebElement PrivacySettings { get; set; }
        [FindsBy(How = How.LinkText, Using = "Shop Our Products")]
        public IWebElement ShopOurProducts { get; set; }



        public void SelectShopOurProducts() 
        {
          
            ShopOurProducts.Clicks();

        }


        public void SelectPrivacySettings()  /// you can also do this  public void SelectPrivacySettings() => PrivacySettings.Clicks();
        {

            PrivacySettings.Clicks();

        }
    }
}
