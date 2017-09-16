using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new CsvToJsonFromFileParser();
            parser.Parse("path/to/database");
        }
    }
}
