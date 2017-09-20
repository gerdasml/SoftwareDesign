using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Strategy
{
    class XmlParsingStrategy : ParsingStrategy
    {
        public string Parse(string data)
        {
            var doc = new XmlDocument();
            doc.LoadXml(data);
            string jsonText = JsonConvert.SerializeXmlNode(doc.DocumentElement);
            Console.WriteLine("Converted XML to JSON: " + jsonText);
            return jsonText;
        }
    }
}
