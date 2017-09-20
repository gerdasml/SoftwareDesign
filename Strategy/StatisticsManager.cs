using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StatisticsManager
    {
        private DataFetcherStrategy _dfs;

        public StatisticsManager(DataFetcherStrategy dfs)
        {
            _dfs = dfs;
        }

        public int GetUpServiceCount(string source)
        {
            Random rnd = new Random();
            int upCount = rnd.Next(1, 100);
            _dfs.Open(source);
            string data = _dfs.Read();
            _dfs.Close();
            Console.WriteLine("Number of services that are up: " + upCount);
            return upCount;
        }
    }
}
