using HelloWorld;
using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class UnitTest
    {
        [Test]
        public void TestHelloWorld()
        {
            Assert.That(Program.GetMessage(), Is.EqualTo("Hello, World!"));
        }
    }
}
