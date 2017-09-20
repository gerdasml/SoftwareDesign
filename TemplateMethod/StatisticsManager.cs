using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class StatisticsManager
    {
        public int GetUpServiceCount(string source)
        {
            Random rnd = new Random();
            int upCount = rnd.Next(1, 100);
            Open(source);
            string data = Read();
            Close();
            return upCount;
        }

        protected abstract void Open(string source);
        protected abstract string Read();
        protected abstract void Close();
    }
}
