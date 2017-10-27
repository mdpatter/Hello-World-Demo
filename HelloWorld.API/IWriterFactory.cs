using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public interface IWriterFactory
    {
        IWriter GetWriter(WriterType writerType);
    }
}
