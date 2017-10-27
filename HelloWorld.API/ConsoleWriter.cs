using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public class ConsoleWriter : Writer, IWriter
    {
        public ConsoleWriter() : base(WriterType.CONSOLE) { }

        public override void Write(string message)
        {
            Console.Write(message);
        }
    }
}
