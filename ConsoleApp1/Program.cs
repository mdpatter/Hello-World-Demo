using HelloWorld.API;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            WriterType writeTo;
            if (!Enum.TryParse<WriterType>(ConfigurationManager.AppSettings["WriteTo"], true, out writeTo))
            {
                Console.WriteLine("Invalid WriteTo option. Program is ending");
                return;
            }
            var baseAddress = ConfigurationManager.AppSettings["HelloWorldDemoUrl"];
            if (string.IsNullOrEmpty(baseAddress))
            {
                Console.WriteLine("HelloWorldDemoUrl not found. Program is ending");
                return;
            }

            var client = new Client(new HttpClient(), baseAddress);
            var writerFactory = new WriterFactory();
            var worker = new Worker(client, writerFactory);

            worker.RunHelloWordAsync(writeTo).GetAwaiter().GetResult();

            Console.ReadKey();
        }
    }
}
