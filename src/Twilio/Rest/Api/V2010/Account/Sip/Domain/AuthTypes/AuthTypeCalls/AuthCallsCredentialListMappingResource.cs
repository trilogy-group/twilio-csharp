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



namespace Kandy.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeCalls
{
    public class AuthCallsCredentialListMappingResource : Resource
    {



        private static Request BuildCreateRequest(CreateAuthCallsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Calls/CredentialListMappings.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{" + "DomainSid" + "}", PathDomainSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="options"> Create AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static AuthCallsCredentialListMappingResource Create(CreateAuthCallsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="options"> Create AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> CreateAsync(CreateAuthCallsCredentialListMappingOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static AuthCallsCredentialListMappingResource Create(
                                          string pathDomainSid,
                                          string credentialListSid,
                                          string pathAccountSid = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateAuthCallsCredentialListMappingOptions(pathDomainSid, credentialListSid) { PathAccountSid = pathAccountSid };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> CreateAsync(
                                                                                  string pathDomainSid,
                                                                                  string credentialListSid,
                                                                                  string pathAccountSid = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateAuthCallsCredentialListMappingOptions(pathDomainSid, credentialListSid) { PathAccountSid = pathAccountSid };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="options"> Delete AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        private static Request BuildDeleteRequest(DeleteAuthCallsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Calls/CredentialListMappings/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{" + "DomainSid" + "}", PathDomainSid);
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

        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="options"> Delete AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static bool Delete(DeleteAuthCallsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="options"> Delete AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAuthCallsCredentialListMappingOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static bool Delete(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchAuthCallsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Calls/CredentialListMappings/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{" + "DomainSid" + "}", PathDomainSid);
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

        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="options"> Fetch AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static AuthCallsCredentialListMappingResource Fetch(FetchAuthCallsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="options"> Fetch AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> FetchAsync(FetchAuthCallsCredentialListMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static AuthCallsCredentialListMappingResource Fetch(
                                         string pathDomainSid,
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> FetchAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAuthCallsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Calls/CredentialListMappings.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{" + "DomainSid" + "}", PathDomainSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="options"> Read AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static ResourceSet<AuthCallsCredentialListMappingResource> Read(ReadAuthCallsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthCallsCredentialListMappingResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="options"> Read AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthCallsCredentialListMappingResource>> ReadAsync(ReadAuthCallsCredentialListMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthCallsCredentialListMappingResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns>
        public static ResourceSet<AuthCallsCredentialListMappingResource> Read(
                                                     string pathDomainSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAuthCallsCredentialListMappingOptions(pathDomainSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthCallsCredentialListMappingResource>> ReadAsync(
                                                                                             string pathDomainSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAuthCallsCredentialListMappingOptions(pathDomainSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AuthCallsCredentialListMappingResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AuthCallsCredentialListMappingResource> NextPage(Page<AuthCallsCredentialListMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AuthCallsCredentialListMappingResource> PreviousPage(Page<AuthCallsCredentialListMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a AuthCallsCredentialListMappingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthCallsCredentialListMappingResource object represented by the provided JSON </returns>
        public static AuthCallsCredentialListMappingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AuthCallsCredentialListMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique string that that we created to identify the CredentialListMapping resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }



        private AuthCallsCredentialListMappingResource()
        {

        }
    }
}
