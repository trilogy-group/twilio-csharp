/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Kandy.Rest.Api.V2010.Account.Recording
{
    public class AddOnResultResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) { }
            public StatusEnum() { }
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Init = new StatusEnum("init");
            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Queued = new StatusEnum("queued");

        }


        /// <summary> Delete a result and purge all associated Payloads </summary>
        /// <param name="options"> Delete AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        private static Request BuildDeleteRequest(DeleteAddOnResultOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Recordings/{ReferenceSid}/AddOnResults/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathReferenceSid = options.PathReferenceSid;
            path = path.Replace("{" + "ReferenceSid" + "}", PathReferenceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a result and purge all associated Payloads </summary>
        /// <param name="options"> Delete AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static bool Delete(DeleteAddOnResultOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a result and purge all associated Payloads </summary>
        /// <param name="options"> Delete AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAddOnResultOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a result and purge all associated Payloads </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to delete belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static bool Delete(string pathReferenceSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAddOnResultOptions(pathReferenceSid, pathSid) { PathAccountSid = pathAccountSid };
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a result and purge all associated Payloads </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to delete belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathReferenceSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAddOnResultOptions(pathReferenceSid, pathSid) { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchAddOnResultOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Recordings/{ReferenceSid}/AddOnResults/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathReferenceSid = options.PathReferenceSid;
            path = path.Replace("{" + "ReferenceSid" + "}", PathReferenceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of an AddOnResult </summary>
        /// <param name="options"> Fetch AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static AddOnResultResource Fetch(FetchAddOnResultOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch an instance of an AddOnResult </summary>
        /// <param name="options"> Fetch AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<AddOnResultResource> FetchAsync(FetchAddOnResultOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch an instance of an AddOnResult </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to fetch belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static AddOnResultResource Fetch(
                                         string pathReferenceSid,
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAddOnResultOptions(pathReferenceSid, pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch an instance of an AddOnResult </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to fetch belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<AddOnResultResource> FetchAsync(string pathReferenceSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchAddOnResultOptions(pathReferenceSid, pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAddOnResultOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Recordings/{ReferenceSid}/AddOnResults.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathReferenceSid = options.PathReferenceSid;
            path = path.Replace("{" + "ReferenceSid" + "}", PathReferenceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of results belonging to the recording </summary>
        /// <param name="options"> Read AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static ResourceSet<AddOnResultResource> Read(ReadAddOnResultOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
            return new ResourceSet<AddOnResultResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of results belonging to the recording </summary>
        /// <param name="options"> Read AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AddOnResultResource>> ReadAsync(ReadAddOnResultOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
            return new ResourceSet<AddOnResultResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of results belonging to the recording </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to read belongs. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns>
        public static ResourceSet<AddOnResultResource> Read(
                                                     string pathReferenceSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAddOnResultOptions(pathReferenceSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of results belonging to the recording </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to read belongs. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AddOnResultResource>> ReadAsync(
                                                                                             string pathReferenceSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAddOnResultOptions(pathReferenceSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AddOnResultResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AddOnResultResource> NextPage(Page<AddOnResultResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AddOnResultResource> PreviousPage(Page<AddOnResultResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a AddOnResultResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AddOnResultResource object represented by the provided JSON </returns>
        public static AddOnResultResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AddOnResultResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that that we created to identify the Recording AddOnResult resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }


        [JsonProperty("status")]
        public AddOnResultResource.StatusEnum Status { get; private set; }

        ///<summary> The SID of the Add-on to which the result belongs. </summary> 
        [JsonProperty("add_on_sid")]
        public string AddOnSid { get; private set; }

        ///<summary> The SID of the Add-on configuration. </summary> 
        [JsonProperty("add_on_configuration_sid")]
        public string AddOnConfigurationSid { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The date and time in GMT that the result was completed specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }

        ///<summary> The SID of the recording to which the AddOnResult resource belongs. </summary> 
        [JsonProperty("reference_sid")]
        public string ReferenceSid { get; private set; }

        ///<summary> A list of related resources identified by their relative URIs. </summary> 
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }



        private AddOnResultResource()
        {

        }
    }
}
