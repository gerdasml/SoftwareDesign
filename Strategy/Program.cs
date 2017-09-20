using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser1 = new Parser(new XmlParsingStrategy(), new DatabaseDataFetcherStrategy());
            var result = parser1.Parse("kazkas");
        }
    }
}
