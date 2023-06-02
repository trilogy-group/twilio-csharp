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
    public class SayTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Say();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say></Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Say("message", Say.VoiceEnum.Man, 1, Say.LanguageEnum.Arb);
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say voice=\"man\" loop=\"1\" language=\"arb\">message</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Say();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say newParam1=\"value\" newParam2=\"1\"></Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Say();

            elem.Break(SsmlBreak.StrengthEnum.None, "time");

            elem.Emphasis("words", SsmlEmphasis.LevelEnum.Strong);

            elem.Lang("words", SsmlLang.XmlLangEnum.Arb);

            elem.P("words");

            elem.Phoneme("words", SsmlPhoneme.AlphabetEnum.Ipa, "ph");

            elem.Prosody("words", "volume", "rate", "pitch");

            elem.S("words");

            elem.SayAs("words", SsmlSayAs.InterpretAsEnum.Characters, SsmlSayAs.FormatEnum.Mdy);

            elem.Sub("words", "alias");

            elem.W("words", "role");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <break strength=\"none\" time=\"time\"></break>" + Environment.NewLine +
                "  <emphasis level=\"strong\">words</emphasis>" + Environment.NewLine +
                "  <lang xml:lang=\"arb\">words</lang>" + Environment.NewLine +
                "  <p>words</p>" + Environment.NewLine +
                "  <phoneme alphabet=\"ipa\" ph=\"ph\">words</phoneme>" + Environment.NewLine +
                "  <prosody volume=\"volume\" rate=\"rate\" pitch=\"pitch\">words</prosody>" + Environment.NewLine +
                "  <s>words</s>" + Environment.NewLine +
                "  <say-as interpret-as=\"characters\" format=\"mdy\">words</say-as>" + Environment.NewLine +
                "  <sub alias=\"alias\">words</sub>" + Environment.NewLine +
                "  <w role=\"role\">words</w>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Say();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>Here is the content</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Say();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Say();
            var child = new SsmlBreak();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <break>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </break>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Say();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>before<Child>content</Child>after</Say>",
                elem.ToString()
            );
        }
    }

}
