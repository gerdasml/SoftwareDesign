using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface DataFetcherStrategy
    {
        void Open(string source);
        string Read();
        void Close();
    }
}
