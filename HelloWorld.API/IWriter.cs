using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public interface IWriter
    {
        WriterType Type { get; }
        void Write(string message);
    }
}
