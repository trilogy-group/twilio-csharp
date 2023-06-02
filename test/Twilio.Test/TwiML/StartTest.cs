/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Kandy.Tests.TwiML
{

    [TestFixture]
    public class StartTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Start();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start></Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Start(new Uri("https://example.com"), Twilio.Http.HttpMethod.Get);
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start action=\"https://example.com\" method=\"GET\"></Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Start();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start newParam1=\"value\" newParam2=\"1\"></Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestNestElement()
        {
            var elem = new Start();
            var child = new Stream();
            elem.Nest(child).Parameter();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>" + Environment.NewLine +
                "  <Stream>" + Environment.NewLine +
                "    <Parameter></Parameter>" + Environment.NewLine +
                "  </Stream>" + Environment.NewLine +
                "</Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Start();

            elem.Stream(
                "name",
                "connector_name",
                "url",
                Stream.TrackEnum.InboundTrack,
                "status_callback",
                Stream.StatusCallbackMethodEnum.Get
            );

            elem.Siprec("name", "connector_name", Siprec.TrackEnum.InboundTrack);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>" + Environment.NewLine +
                "  <Stream name=\"name\" connectorName=\"connector_name\" url=\"url\" track=\"inbound_track\" statusCallback=\"status_callback\" statusCallbackMethod=\"GET\"></Stream>" + Environment.NewLine +
                "  <Siprec name=\"name\" connectorName=\"connector_name\" track=\"inbound_track\"></Siprec>" + Environment.NewLine +
                "</Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Start();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>Here is the content</Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Start();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Start();
            var child = new Stream();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>" + Environment.NewLine +
                "  <Stream>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Stream>" + Environment.NewLine +
                "</Start>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Start();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Start>before<Child>content</Child>after</Start>",
                elem.ToString()
            );
        }
    }

}
