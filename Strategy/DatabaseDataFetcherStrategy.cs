using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DatabaseDataFetcherStrategy : DataFetcherStrategy
    {
        //private SqlConnection _connection;
        public void Open(string source)
        {
            //_connection = new SqlConnection(source);
            //_connection.Open();
            Console.WriteLine("Connecting to database...");
        }

        public string Read()
        {
            // use _connection to fetch data
            // Here should be implementation
            string xmlData = "<text>Here should be XML.</text>";
            //string csvData = "H1,H2,H3\nData11,Data12,Data13\nData21,Data22,Data23";
            Console.WriteLine("Fetched XML: "+xmlData);
            return xmlData;
        }

        public void Close()
        {
            //_connection.Close();
            Console.WriteLine("Database was closed successfully");
        }
    }
}
