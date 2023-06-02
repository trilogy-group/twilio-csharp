﻿using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Twilio.Jwt;
using Twilio.Tests.Jwt;

namespace Kandy.Tests.Jwt
{
    class TestJwt : BaseJwt
    {
        public static string SECRET = "superduperduperdupersecret";
        
        private DateTime? _nbf;

        public TestJwt(DateTime exp, DateTime? nbf = null) : base(TestJwt.SECRET, "issuer", exp)
        {
            this._nbf = nbf;
        }

        public override Dictionary<string, object> Headers => new Dictionary<string, object>();
        public override Dictionary<string, object> Claims => new Dictionary<string, object>();
        public override DateTime? Nbf { get => this._nbf; }
    }
        
    public class BaseJwtTest
    {
        static DateTime TEST_TIME = new DateTime(2037, 9, 7, 9, 0, 0, DateTimeKind.Utc);
        static long TEST_TIMESTAMP = 2135926800;     // 9/7/2037 9:00am (utc) in unix timestamp form
        private static TimeZoneInfo OTHER_TZ = TimeZoneInfo.Local;

        [Test]
        public void TestSetUtcExp()
        {
            var encoded = new TestJwt(TEST_TIME).ToJwt();
            var decoded = new DecodedJwt(encoded, TestJwt.SECRET);

            Assert.AreEqual(TEST_TIMESTAMP, decoded.Payload["exp"]);
        }
        
        [Test]
        public void TestSetLocalTimeExp()
        {
            // Convert to PST before passing to JWT
            var exp = TimeZoneInfo.ConvertTime(TEST_TIME, OTHER_TZ);

            var encoded = new TestJwt(exp).ToJwt();
            var decoded = new DecodedJwt(encoded, TestJwt.SECRET);

            Assert.AreEqual(TEST_TIMESTAMP, decoded.Payload["exp"]);
        }
        
        [Test]
        public void TestSetUtcNbf()
        {
            var encoded = new TestJwt(DateTime.UtcNow.AddHours(1), TEST_TIME).ToJwt();
            var decoded = new DecodedJwt(encoded, TestJwt.SECRET);

            Assert.AreEqual(TEST_TIMESTAMP, decoded.Payload["nbf"]);
        }
        
        [Test]
        public void TestSetLocalTimeNbf()
        {
            var nbf = TimeZoneInfo.ConvertTime(TEST_TIME, OTHER_TZ);

            var encoded = new TestJwt(DateTime.UtcNow.AddHours(1), nbf).ToJwt();
            var decoded = new DecodedJwt(encoded, TestJwt.SECRET);

            Assert.AreEqual(TEST_TIMESTAMP, decoded.Payload["nbf"]);
        }
    }
}
