using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Advanced_Assignment
{/// <summary>
    /// Uses variable path set in the system's environment variables.
    /// Reads application configuration from a configuration file.
    /// </summary>
    public class Configuration
    {
        public static int MinWorldSize { get; private set; }
        public static int MaxWorldSize { get; private set; }

        static string FilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/Config.xml";
        
        public static void ReadConfig()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(FilePath);
            XmlNode root = configDoc.DocumentElement;



            XmlNode minWorldSize = configDoc.DocumentElement.SelectSingleNode("MinWorldSize");
            if (minWorldSize != null)
            {
                string str = minWorldSize.InnerText.Trim();
                MinWorldSize = Convert.ToInt32(str);
            }

            XmlNode maxWorldSize = configDoc.DocumentElement.SelectSingleNode("MaxWorldSize");
            if (maxWorldSize != null)
            {
                string str = maxWorldSize.InnerText.Trim();
                MaxWorldSize = Convert.ToInt32(str);
            }
        }
    }
}
