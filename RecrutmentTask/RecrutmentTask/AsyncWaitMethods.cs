using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutmentTask
{
    class AsyncWaitMethods
    {

        public static void WaitByName(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.Name(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }

            
        }

        public static void WaitById(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }
        }

        public static void WaitByLinkText(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }
        }

        public static void WaitByXPath(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }
        }

        public static void WaitByCssSelector(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }
        }

        public static void WaitByClassName(int time, string value)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
                IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(value)));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine("Timeout");
            }
        }

    }
}
