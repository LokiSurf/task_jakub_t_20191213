using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutmentTask
{

    // po to to robimy na wypadeg dymy zmienila selektory (elementtype) np z Id na ids
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


    class PropertiesCollection
    {

        //Auto imlemented Property - driver instance 
        public static IWebDriver driver { get; set; }
    }
}
