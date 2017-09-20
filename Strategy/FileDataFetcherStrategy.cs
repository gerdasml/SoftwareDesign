using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FileDataFetcherStrategy : DataFetcherStrategy
    {
        public void Open(string source)
        {
            //_file = new StreamReader(source);
            Console.WriteLine("File was opened successfully");
        }

        public string Read()
        {
            // use _connection to fetch data
            // Here should be implementation
            string xmlData = "<text>Here should be XML.</text>";
            //string csvData = "H1,H2,H3\nData11,Data12,Data13\nData21,Data22,Data23";
            //Console.WriteLine("Fetched CSV: " + csvData);
            Console.WriteLine("Fetched XML: " + xmlData);
            return xmlData;
        }

        public void Close()
        {
            //_file.Close();
            Console.WriteLine("File was closed successfully");
        }
    }
}
