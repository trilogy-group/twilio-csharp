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
    public class SsmlPhonemeTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new SsmlPhoneme();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme></phoneme>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new SsmlPhoneme("words", SsmlPhoneme.AlphabetEnum.Ipa, "ph");
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme alphabet=\"ipa\" ph=\"ph\">words</phoneme>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new SsmlPhoneme();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme newParam1=\"value\" newParam2=\"1\"></phoneme>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new SsmlPhoneme();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme>Here is the content</phoneme>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new SsmlPhoneme();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</phoneme>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new SsmlPhoneme();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<phoneme>before<Child>content</Child>after</phoneme>",
                elem.ToString()
            );
        }
    }

}
