/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Api
 * This is the public Kandy REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Kandy.Base;
using Kandy.Clients;
using Kandy.Converters;
using Kandy.Exceptions;
using Kandy.Http;



namespace Kandy.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeRegistrations
{
    public class AuthRegistrationsCredentialListMappingResource : Resource
    {



        private static Request BuildCreateRequest(CreateAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Registrations/CredentialListMappings.json";

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
        /// <param name="options"> Create AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static AuthRegistrationsCredentialListMappingResource Create(CreateAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="options"> Create AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> CreateAsync(CreateAuthRegistrationsCredentialListMappingOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static AuthRegistrationsCredentialListMappingResource Create(
                                          string pathDomainSid,
                                          string credentialListSid,
                                          string pathAccountSid = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateAuthRegistrationsCredentialListMappingOptions(pathDomainSid, credentialListSid) { PathAccountSid = pathAccountSid };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a new credential list mapping resource </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> CreateAsync(
                                                                                  string pathDomainSid,
                                                                                  string credentialListSid,
                                                                                  string pathAccountSid = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateAuthRegistrationsCredentialListMappingOptions(pathDomainSid, credentialListSid) { PathAccountSid = pathAccountSid };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="options"> Delete AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        private static Request BuildDeleteRequest(DeleteAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Registrations/CredentialListMappings/{Sid}.json";

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
        /// <param name="options"> Delete AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static bool Delete(DeleteAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="options"> Delete AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAuthRegistrationsCredentialListMappingOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the CredentialListMapping resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resources to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static bool Delete(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a credential list mapping from the requested domain </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the CredentialListMapping resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resources to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Registrations/CredentialListMappings/{Sid}.json";

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
        /// <param name="options"> Fetch AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static AuthRegistrationsCredentialListMappingResource Fetch(FetchAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="options"> Fetch AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> FetchAsync(FetchAuthRegistrationsCredentialListMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the CredentialListMapping resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static AuthRegistrationsCredentialListMappingResource Fetch(
                                         string pathDomainSid,
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a specific instance of a credential list mapping </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the CredentialListMapping resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> FetchAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/Domains/{DomainSid}/Auth/Registrations/CredentialListMappings.json";

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
        /// <param name="options"> Read AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static ResourceSet<AuthRegistrationsCredentialListMappingResource> Read(ReadAuthRegistrationsCredentialListMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthRegistrationsCredentialListMappingResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="options"> Read AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthRegistrationsCredentialListMappingResource>> ReadAsync(ReadAuthRegistrationsCredentialListMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthRegistrationsCredentialListMappingResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static ResourceSet<AuthRegistrationsCredentialListMappingResource> Read(
                                                     string pathDomainSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAuthRegistrationsCredentialListMappingOptions(pathDomainSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthRegistrationsCredentialListMappingResource>> ReadAsync(
                                                                                             string pathDomainSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAuthRegistrationsCredentialListMappingOptions(pathDomainSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<AuthRegistrationsCredentialListMappingResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<AuthRegistrationsCredentialListMappingResource> NextPage(Page<AuthRegistrationsCredentialListMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<AuthRegistrationsCredentialListMappingResource> PreviousPage(Page<AuthRegistrationsCredentialListMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a AuthRegistrationsCredentialListMappingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthRegistrationsCredentialListMappingResource object represented by the provided JSON </returns>
        public static AuthRegistrationsCredentialListMappingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AuthRegistrationsCredentialListMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the CredentialListMapping resource. </summary> 
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



        private AuthRegistrationsCredentialListMappingResource()
        {

        }
    }
}
