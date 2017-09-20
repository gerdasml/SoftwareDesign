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

namespace Strategy
{
    class CsvParsingStrategy : ParsingStrategy
    {
        public string Parse(string data)
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

            Console.WriteLine("Converted CSV to JSON: " + result.ToString());
            return result.ToString();
        }
    }
}
