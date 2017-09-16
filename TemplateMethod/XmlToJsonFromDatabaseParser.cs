using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace TemplateMethod
{
    class XmlToJsonFromDatabaseParser : Parser
    {
        //private SqlConnection _connection;
        protected override void Open(string source)
        {
            //_connection = new SqlConnection(source);
            //_connection.Open();
            Console.WriteLine("Connecting to database...");
        }

        protected override string Read()
        {
            // use _connection to fetch data
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
            //_connection.Close();
            Console.WriteLine("Database was closed successfully");
        }
    }
}
