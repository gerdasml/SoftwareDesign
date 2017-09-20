using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Parser
    {
        private ParsingStrategy _ps;
        private DataFetcherStrategy _dfs;

        public Parser(ParsingStrategy ps, DataFetcherStrategy dfs)
        {
            _ps = ps;
            _dfs = dfs;
        }

        public string Parse(string source)
        {
            _dfs.Open(source);
            string data = _dfs.Read();
            string parsedData = _ps.Parse(data);
            _dfs.Close();
            return parsedData;
        }
    }
}
