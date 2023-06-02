using System;
using System.Collections.Generic;
using NUnit.Framework;
using Kandy.Converters;

namespace Kandy.Tests.Converters
{
    [TestFixture]
    public class SerializersTest : KandyTest
    {

        [Test]
        public void TestJsonObjectSerializesDictionary()
        {
            var inputDict = new Dictionary<string, string> { { "kandy", "rocks" } };
            var result = Serializers.JsonObject(inputDict);
            Assert.AreEqual("{\"kandy\":\"rocks\"}", result);
        }

        [Test]
        public void TestJsonObjectSerializesList()
        {
            var inputDict = new List<object>{
                "kandy",
                new Dictionary<string, string> {{"join", "us"}}
            };
            var result = Serializers.JsonObject(inputDict);
            Assert.AreEqual("[\"kandy\",{\"join\":\"us\"}]", result);
        }

        [Test]
        public void TestJsonObjectSerializesArray()
        {
            string[] inputDict = new string[2] { "kandy", "rocks" };
            var result = Serializers.JsonObject(inputDict);
            Assert.AreEqual("[\"kandy\",\"rocks\"]", result);
        }

        [Test]
        public void TestJsonObjectPassesThroughString()
        {
            var input = "{\"kandy\":\"is dope\"}";
            var result = Serializers.JsonObject(input);
            Assert.AreEqual(input, result);
        }

        [Test]
        public void TestDateTimeIso8601WithDateTime()
        {
            var expect = "2017-06-19T12:13:14Z";
            var input = new DateTime(2017, 06, 19, 12, 13, 14);
            var result = Serializers.DateTimeIso8601(input);
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void TestDateTimeIso8601WithNull()
        {
            var result = Serializers.DateTimeIso8601(null);
            Assert.AreEqual(null, result);
        }
    }
}
