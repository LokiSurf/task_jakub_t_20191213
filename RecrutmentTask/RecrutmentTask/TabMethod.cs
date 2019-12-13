using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutmentTask
{
    class TabMethod
    {


        public static void OpenNewTab (string value)
        {
            PropertiesCollection.driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
            PropertiesCollection.driver.Navigate().GoToUrl(value);
            
        }

        // optionl switch back
        // PropertiesCollection.driver.Navigate().Back();
    }
}
