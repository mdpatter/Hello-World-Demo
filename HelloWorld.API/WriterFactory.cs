using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public class WriterFactory : IWriterFactory
    {       
        public IWriter GetWriter(WriterType writerType)
        {
            switch (writerType)
            {
                case WriterType.CONSOLE:                    
                    return new ConsoleWriter();
                default:
                    throw new ArgumentException($"{writerType} writer not available at this time");
            }
        }
    }
}
