using NUnit.Framework;
using System;
using System.Collections.Generic;
using Kandy;
using Kandy.Rest.Api.V2010.Account;
using Kandy.Rest.Chat.V2;
using Kandy.Rest.Chat.V2.Service;
using Kandy.Rest.Events.V1;
using System.Linq;
namespace Kandy.Tests
{
    [TestFixture]
    class ClusterTest
    {
        string accountSid;
        string secret;
        private string apiKey;
        string toNumber;
        string fromNumber;
        [SetUp]
        [Category("ClusterTest")]
        public void SetUp()
        {
            accountSid = Environment.GetEnvironmentVariable("KANDY_ACCOUNT_SID");
            secret = Environment.GetEnvironmentVariable("KANDY_API_SECRET");
            apiKey = Environment.GetEnvironmentVariable("KANDY_API_KEY");
            toNumber = Environment.GetEnvironmentVariable("KANDY_TO_NUMBER");
            fromNumber = Environment.GetEnvironmentVariable("KANDY_FROM_NUMBER");
            KandyClient.Init(username: apiKey, password: secret, accountSid: accountSid);
        }


        [Test]
        [Category("ClusterTest")]
        public void TestSendingAText()
        {
            var message = MessageResource.Create(
               from: new Kandy.Types.PhoneNumber(fromNumber),
               body: "Where's Wallace?",
               to: new Kandy.Types.PhoneNumber(toNumber)
           );
            Assert.IsNotNull(message);
            Assert.True(message.Body.Contains("Where's Wallace?"));
            Assert.AreEqual(fromNumber, message.From.ToString());
            Assert.AreEqual(toNumber, message.To.ToString());
        }

        [Test]
        [Category("ClusterTest")]
        public void TestListingNumbers()
        {
            var incomingPhoneNumberResourceSet = IncomingPhoneNumberResource.Read(
                phoneNumber: new Kandy.Types.PhoneNumber(fromNumber)
            );
            Assert.IsNotNull(incomingPhoneNumberResourceSet);
            Assert.Greater(incomingPhoneNumberResourceSet.Count(), 0);
        }

        [Test]
        [Category("ClusterTest")]
        public void TestListingANumber()
        {

            var incomingPhoneNumberResourceSet = IncomingPhoneNumberResource.Read(
                phoneNumber: new Kandy.Types.PhoneNumber(fromNumber)
            );
            var enumerator = incomingPhoneNumberResourceSet.GetEnumerator();
            enumerator.MoveNext();
            var firstPage = enumerator.Current;
            Assert.IsNotNull(firstPage);
            Assert.AreEqual(fromNumber, firstPage.PhoneNumber.ToString());
        }

        [Test]
        [Category("ClusterTest")]
        public void TestSpecialCharacters()
        {
            var service = ServiceResource.Create(friendlyName: "service|friendly&name");
            Assert.IsNotNull(service);
            UserResource user = UserResource.Create(pathServiceSid: service.Sid, identity: "user|identity&string");
            Assert.IsNotNull(user);
            bool isUserDeleted = UserResource.Delete(pathServiceSid: service.Sid, pathSid: user.Sid);
            Assert.True(isUserDeleted);
            bool isServiceDeleted = ServiceResource.Delete(pathSid: service.Sid);
            Assert.True(isServiceDeleted);
        }

        [Test]
        [Category("ClusterTest")]
        public void TestListParams()
        {
            var sinkConfiguration = new Dictionary<string, Object>()
            {
                {"destination", "http://example.org/webhook"},
                {"method", "post"},
                {"batch_events",false}
            };

            var types1 = new Dictionary<string, Object>(){
                {"type","com.kandy.messaging.message.delivered"},
            };

            var types2 = new Dictionary<string, Object>(){
                {"type", "com.kandy.messaging.message.sent"},
            };

            var types = new List<Object>(){
                types1,types2
            };

            var sink = SinkResource.Create(
                description: "test sink csharp",
                sinkConfiguration: sinkConfiguration,
                sinkType: SinkResource.SinkTypeEnum.Webhook
             );
            Assert.IsNotNull(sink);

            var subscription = SubscriptionResource.Create("test subscription csharp", sink.Sid, types);
            Assert.IsNotNull(subscription);

            Assert.True(SubscriptionResource.Delete(subscription.Sid));
            Assert.True(SinkResource.Delete(sink.Sid));

        }
    }
}
