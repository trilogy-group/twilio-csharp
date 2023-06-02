using System;
using NUnit.Framework;
using Kandy.Jwt.Client;

namespace Kandy.Tests.Jwt.Client
{
    [TestFixture]
    public class IncomingClientScopeTest
    {
        [Test]
        public void TestGenerate()
        {
            var scope = new IncomingClientScope("foobar");
            Assert.AreEqual(
                "scope:client:incoming?clientName=foobar",
                scope.Payload
            );
        }
    }
}
