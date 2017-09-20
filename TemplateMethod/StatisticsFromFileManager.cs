using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class StatisticsFromFileManager : StatisticsManager
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
            Console.WriteLine("Fetched data: 1 2 5 4 495849 39933 3 4505 04040");
            return "1 2 5 4 495849 39933 3 4505 04040";
        }
        
        protected override void Close()
        {
            //_file.Close();
            Console.WriteLine("File was closed successfully");
        }
    }
}
