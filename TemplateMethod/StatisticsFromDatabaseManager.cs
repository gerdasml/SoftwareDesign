using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class StatisticsFromDatabaseManager : StatisticsManager
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
            Console.WriteLine("Fetched XML: 746547 3083480 3098390584 398429843 3985395849 3985948 90232084 2832938");
            return "746547 3083480 3098390584 398429843 3985395849 3985948 90232084 2832938";
        }

        protected override void Close()
        {
            //_connection.Close();
            Console.WriteLine("Database was closed successfully");
        }
    }
}
