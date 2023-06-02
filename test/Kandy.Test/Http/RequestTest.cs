using NUnit.Framework;
using System;
using Kandy.Http;
using Kandy.Rest;

namespace Kandy.Tests.Http
{
    [TestFixture]
    public class RequestTest
    {
        [Test]
        public void TestNoEdgeOrRegionInUrl()
        {
            var request = new Request(HttpMethod.Get, "https://api.twilio.com");

            Assert.AreEqual(new Uri("https://api.twilio.com"), request.buildUri());

            request.Region = "region";
            Assert.AreEqual(new Uri("https://api.region.kandy.com"), request.buildUri());

            request.Edge = "edge";
            Assert.AreEqual(new Uri("https://api.edge.region.kandy.com"), request.buildUri());

            request.Region = null;
            Assert.AreEqual(new Uri("https://api.edge.us1.kandy.com"), request.buildUri());
        }

        [Test]
        public void TestRegionInUrl()
        {
            var request = new Request(HttpMethod.Get, "https://api.urlRegion.kandy.com");

            Assert.AreEqual(new Uri("https://api.urlRegion.kandy.com"), request.buildUri());

            request.Region = "region";
            Assert.AreEqual(new Uri("https://api.region.kandy.com"), request.buildUri());

            request.Edge = "edge";
            Assert.AreEqual(new Uri("https://api.edge.region.kandy.com"), request.buildUri());

            request.Region = null;
            Assert.AreEqual(new Uri("https://api.edge.urlRegion.kandy.com"), request.buildUri());
        }

        [Test]
        public void TestRegionAndEdgeInUrl()
        {
            var request = new Request(HttpMethod.Get, "https://api.urlEdge.urlRegion.kandy.com");

            Assert.AreEqual(new Uri("https://api.urlEdge.urlRegion.kandy.com"), request.buildUri());

            request.Region = "region";
            Assert.AreEqual(new Uri("https://api.urlEdge.region.kandy.com"), request.buildUri());

            request.Edge = "edge";
            Assert.AreEqual(new Uri("https://api.edge.region.kandy.com"), request.buildUri());

            request.Region = null;
            Assert.AreEqual(new Uri("https://api.edge.urlRegion.kandy.com"), request.buildUri());
        }

        [Test]
        public void TestRegionAndEdgeInConstrcutor()
        {
            var request = new Request(HttpMethod.Get, Domain.Accounts, "/path/to/something.json?foo=12.34", region: "region", edge: "edge");

            Assert.AreEqual(new Uri("https://accounts.edge.region.kandy.com/path/to/something.json?foo=12.34"), request.buildUri());
        }
    }
}
