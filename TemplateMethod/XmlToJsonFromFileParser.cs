using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml;

namespace TemplateMethod
{
    class XmlToJsonFromFileParser : Parser
    {
        //private StreamReader _file;
        protected override void Open(string source)
        {
            //_file = new StreamReader(source);
            Console.WriteLine("File was opened successfully");
        }

        protected override string Read()
        {
            //string rawData = _file.ReadToEnd();
            // Here should be implementation
            Console.WriteLine("Fetched XML: <text>Here should be XML.</text>");
            return "<text>Here should be XML.</text>";
        }

        protected override string ParseInternal(string data)
        {
            var doc = new XmlDocument();
            doc.LoadXml(data);
            string jsonText = JsonConvert.SerializeXmlNode(doc.DocumentElement);
            Console.WriteLine("Converted XML to JSON: " + jsonText);
            return jsonText;
        }

        protected override void Close()
        {
            //_file.Close();
            Console.WriteLine("File was closed successfully");
        }
    }
}
