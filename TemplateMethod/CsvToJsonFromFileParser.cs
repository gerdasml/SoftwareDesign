using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace TemplateMethod
{
    class CsvToJsonFromFileParser : Parser
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
            Console.WriteLine("Fetched CSV: Data11,Data12,Data13\nData21,Data22,Data23");
            return "H1,H2,H3\nData11,Data12,Data13\nData21,Data22,Data23";
        }

        protected override string ParseInternal(string data)
        {
            var lines = data.Split('\n');

            var csv = lines.Select(l => l.Split(',')).ToList();

            var headers = csv[0];
            var dicts = csv.Skip(1).Select(row => Enumerable.Zip(headers, row, Tuple.Create).ToDictionary(p => p.Item1, p => p.Item2)).ToArray();
            JObject result = new JObject();
            JArray arr = new JArray();

            foreach (var obj in csv.Skip(1))
            {
                JObject o = new JObject();
                for (int i = 0; i < obj.Length; i++)
                {
                    o[headers[i]] = obj[i];
                }
                arr.Add(o);
            }

            result["data"] = arr;

            Console.WriteLine("Converted CSV to JSON: "+result.ToString());
            return result.ToString();
        }

        protected override void Close()
        {
            //_file.Close();
            Console.WriteLine("File was closed successfully");
        }
    }
}
