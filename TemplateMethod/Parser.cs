using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Parser
    {
        public string Parse(string source)
        {
            Open(source);
            string data = Read();
            string parsedData = ParseInternal(data);
            Close();
            return parsedData;
        }

        protected abstract void Open(string source);
        protected abstract string Read();
        protected abstract string ParseInternal(string data);
        protected abstract void Close();
    }
}
