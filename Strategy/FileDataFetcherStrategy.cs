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
          
        }

        public string Read()
        {
            return "";
        }

        public void Close()
        {

        }
    }
}
