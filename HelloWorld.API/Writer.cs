using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public abstract class Writer : IWriter
    {
        public Writer(WriterType type)
        {
            Type = type;
        }
        public WriterType Type { get; }

        public abstract void Write(string message);
    }
}
