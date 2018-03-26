using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace MyTest
{
   public class XMLTest
    {
       public static void EditConfig(string newStr,string key)
       {
           XmlDocument doc = new XmlDocument();
           var path = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
           doc.Load(path);
           XmlNodeList nodes = doc.GetElementsByTagName("add");
           for (int i = 0; i < nodes.Count; i++)
           {
               XmlAttribute item = nodes[i].Attributes["name"];
               if (nodes[i].Attributes["name"].Value == key)
               {
                   nodes[i].Attributes["connectionString"].Value = newStr;
                   break;
               }
           }
           doc.Save(path);
           System.Configuration.ConfigurationManager.RefreshSection("appSettings");
       }
    }
}
