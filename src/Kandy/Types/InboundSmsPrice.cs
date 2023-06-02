﻿using Newtonsoft.Json;
using Kandy.Converters;

namespace Kandy.Types
{
    /// <summary>
    /// POCO for inbound SMS prices
    /// </summary>
    public class InboundSmsPrice
    {
        /// <summary>
        /// Phone number types
        /// </summary>
        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) { }

            /// <summary>
            /// Generic constructor
            /// </summary>
            public TypeEnum() { }

            /// <summary>
            /// Local number type
            /// </summary>
            public static readonly TypeEnum Local = new TypeEnum("local");

            /// <summary>
            /// Mobile number type
            /// </summary>
            public static readonly TypeEnum Mobile = new TypeEnum("mobile");

            /// <summary>
            /// National number type
            /// </summary>
            public static readonly TypeEnum National = new TypeEnum("national");

            /// <summary>
            /// Shortcode number type
            /// </summary>
            public static readonly TypeEnum Shortcode = new TypeEnum("shortcode");

            /// <summary>
            /// Toll Free number type
            /// </summary>
            public static readonly TypeEnum TollFree = new TypeEnum("toll free");
        }

        /// <summary>
        /// Base price for SMS
        /// </summary>
        [JsonProperty("base_price")]
        public double? BasePrice { get; private set; }

        /// <summary>
        /// Current price for SMS
        /// </summary>
        [JsonProperty("current_price")]
        public double? CurrentPrice { get; private set; }

        /// <summary>
        /// Type of number
        /// </summary>
        [JsonProperty("number_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeEnum NumberType { get; private set; }

        /// <summary>
        /// Generic constructor
        /// </summary>
        public InboundSmsPrice() { }

        private InboundSmsPrice(
            [JsonProperty("base_price")]
            double? basePrice,
            [JsonProperty("current_priece")]
            double? currentPrice,
            [JsonProperty("number_type")]
            TypeEnum numberType
        )
        {
            BasePrice = basePrice;
            CurrentPrice = currentPrice;
            NumberType = numberType;
        }
    }
}
