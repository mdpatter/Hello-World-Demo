using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public interface IWorker
    {
        Task RunHelloWordAsync(WriterType writeTo);
    }
}
