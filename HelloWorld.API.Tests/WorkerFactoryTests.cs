using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API.Tests
{
    [TestFixture]
    public class WorkerFactoryTests
    {
        [Test]
        public void GetWriterTest()
        {
            var expectedType = WriterType.CONSOLE;
            var factory = new WriterFactory();            
            var writer = factory.GetWriter(expectedType);
            var actualType = writer.Type;
            Assert.AreEqual(expectedType, actualType);
            Assert.True(writer is ConsoleWriter);
        }
    }
}
