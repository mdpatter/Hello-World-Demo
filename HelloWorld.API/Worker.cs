using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public class Worker : IWorker
    {
        private readonly IClient _client;
        private readonly IWriterFactory _writerFactory;        

        public Worker(IClient client, IWriterFactory writerFactory)
        {
            _client = client;
            _writerFactory = writerFactory;
        }

        public async Task RunHelloWordAsync(WriterType writeTo)
        {
            var message = await _client.GetHelloWorldAsync();
            _writerFactory.GetWriter(writeTo).Write(message);
        }
    }
}
