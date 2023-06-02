/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// Adding A Pause Between Sentences in Say
    /// </summary>
    public class SsmlS : TwiML
    {
        /// <summary>
        /// Words to speak
        /// </summary>
        public string Words { get; set; }

        /// <summary>
        /// Create a new SsmlS
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        public SsmlS(string words = null) : base("s")
        {
            this.Words = words;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Words != null ? this.Words : string.Empty;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        public SsmlS Break(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            var newChild = new SsmlBreak(strength, time);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Break/> element as a child of this element
        /// </summary>
        /// <param name="ssmlBreak"> A SsmlBreak instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlBreak(SsmlBreak ssmlBreak)
        {
            this.Append(ssmlBreak);
            return this;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        [System.Obsolete("This method is deprecated, use .Break() instead.")]
        public SsmlS SsmlBreak(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            return Break(strength, time);
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        public SsmlS Emphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            var newChild = new SsmlEmphasis(words, level);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Emphasis/> element as a child of this element
        /// </summary>
        /// <param name="ssmlEmphasis"> A SsmlEmphasis instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlEmphasis(SsmlEmphasis ssmlEmphasis)
        {
            this.Append(ssmlEmphasis);
            return this;
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        [System.Obsolete("This method is deprecated, use .Emphasis() instead.")]
        public SsmlS SsmlEmphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            return Emphasis(words, level);
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        public SsmlS Lang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            var newChild = new SsmlLang(words, xmlLang);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Lang/> element as a child of this element
        /// </summary>
        /// <param name="ssmlLang"> A SsmlLang instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlLang(SsmlLang ssmlLang)
        {
            this.Append(ssmlLang);
            return this;
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        [System.Obsolete("This method is deprecated, use .Lang() instead.")]
        public SsmlS SsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            return Lang(words, xmlLang);
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        public SsmlS Phoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            var newChild = new SsmlPhoneme(words, alphabet, ph);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Phoneme/> element as a child of this element
        /// </summary>
        /// <param name="ssmlPhoneme"> A SsmlPhoneme instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlPhoneme(SsmlPhoneme ssmlPhoneme)
        {
            this.Append(ssmlPhoneme);
            return this;
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        [System.Obsolete("This method is deprecated, use .Phoneme() instead.")]
        public SsmlS SsmlPhoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            return Phoneme(words, alphabet, ph);
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        public SsmlS Prosody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            var newChild = new SsmlProsody(words, volume, rate, pitch);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Prosody/> element as a child of this element
        /// </summary>
        /// <param name="ssmlProsody"> A SsmlProsody instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlProsody(SsmlProsody ssmlProsody)
        {
            this.Append(ssmlProsody);
            return this;
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        [System.Obsolete("This method is deprecated, use .Prosody() instead.")]
        public SsmlS SsmlProsody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            return Prosody(words, volume, rate, pitch);
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="format"> Specify the format of the date when interpret-as is set to date </param>
        public SsmlS SayAs(string words = null,
                           SsmlSayAs.InterpretAsEnum interpretAs = null,
                           SsmlSayAs.FormatEnum format = null)
        {
            var newChild = new SsmlSayAs(words, interpretAs, format);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Say-As/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSayAs"> A SsmlSayAs instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlSayAs(SsmlSayAs ssmlSayAs)
        {
            this.Append(ssmlSayAs);
            return this;
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="format"> Specify the format of the date when interpret-as is set to date </param>
        [System.Obsolete("This method is deprecated, use .SayAs() instead.")]
        public SsmlS SsmlSayAs(string words = null,
                               SsmlSayAs.InterpretAsEnum interpretAs = null,
                               SsmlSayAs.FormatEnum format = null)
        {
            return SayAs(words, interpretAs, format);
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        public SsmlS Sub(string words = null, string alias = null)
        {
            var newChild = new SsmlSub(words, alias);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Sub/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSub"> A SsmlSub instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlSub(SsmlSub ssmlSub)
        {
            this.Append(ssmlSub);
            return this;
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        [System.Obsolete("This method is deprecated, use .Sub() instead.")]
        public SsmlS SsmlSub(string words = null, string alias = null)
        {
            return Sub(words, alias);
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        public SsmlS W(string words = null, string role = null)
        {
            var newChild = new SsmlW(words, role);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <W/> element as a child of this element
        /// </summary>
        /// <param name="ssmlW"> A SsmlW instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlS SsmlW(SsmlW ssmlW)
        {
            this.Append(ssmlW);
            return this;
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        [System.Obsolete("This method is deprecated, use .W() instead.")]
        public SsmlS SsmlW(string words = null, string role = null)
        {
            return W(words, role);
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlS Append(TwiML childElem)
        {
            return (SsmlS) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlS SetOption(string key, object value)
        {
            return (SsmlS) base.SetOption(key, value);
        }
    }

}
