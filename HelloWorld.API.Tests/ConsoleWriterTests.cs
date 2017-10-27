using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API.Tests
{
    [TestFixture]
    public class ConsoleWriterTests
    {
        [Test]
        public void WriterTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);               
                var expectedMsg = "Expected Message";
                var writer = new ConsoleWriter();

                writer.Write(expectedMsg);
              
                Assert.AreEqual(expectedMsg, sw.ToString());
            }
        }
    }
}
