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


namespace Kandy.Rest.Api.V2010
{
    public class AccountResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Suspended = new StatusEnum("suspended");
            public static readonly StatusEnum Closed = new StatusEnum("closed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }
            public static readonly TypeEnum Trial = new TypeEnum("Trial");
            public static readonly TypeEnum Full = new TypeEnum("Full");

        }

        
        private static Request BuildCreateRequest(CreateAccountOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts.json";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Twilio Subaccount from the account making the request </summary>
        /// <param name="options"> Create Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Create(CreateAccountOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Twilio Subaccount from the account making the request </summary>
        /// <param name="options"> Create Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<AccountResource> CreateAsync(CreateAccountOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Twilio Subaccount from the account making the request </summary>
        /// <param name="friendlyName"> A human readable description of the account to create, defaults to `SubAccount Created at {YYYY-MM-DD HH:MM meridian}` </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Create(
                                          string friendlyName = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateAccountOptions(){  FriendlyName = friendlyName };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Twilio Subaccount from the account making the request </summary>
        /// <param name="friendlyName"> A human readable description of the account to create, defaults to `SubAccount Created at {YYYY-MM-DD HH:MM meridian}` </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<AccountResource> CreateAsync(
                                                                                  string friendlyName = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateAccountOptions(){  FriendlyName = friendlyName };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchAccountOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{Sid}.json";

            string PathSid = options.PathSid ?? client.AccountSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the account specified by the provided Account Sid </summary>
        /// <param name="options"> Fetch Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Fetch(FetchAccountOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch the account specified by the provided Account Sid </summary>
        /// <param name="options"> Fetch Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<AccountResource> FetchAsync(FetchAccountOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch the account specified by the provided Account Sid </summary>
        /// <param name="pathSid"> The Account Sid that uniquely identifies the account to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Fetch(
                                         string pathSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAccountOptions(){ PathSid = pathSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch the account specified by the provided Account Sid </summary>
        /// <param name="pathSid"> The Account Sid that uniquely identifies the account to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<AccountResource> FetchAsync(string pathSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAccountOptions(){ PathSid = pathSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAccountOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts.json";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieves a collection of Accounts belonging to the account used to make the request </summary>
        /// <param name="options"> Read Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static ResourceSet<AccountResource> Read(ReadAccountOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AccountResource>.FromJson("accounts", response.Content);
            return new ResourceSet<AccountResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieves a collection of Accounts belonging to the account used to make the request </summary>
        /// <param name="options"> Read Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AccountResource>> ReadAsync(ReadAccountOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AccountResource>.FromJson("accounts", response.Content);
            return new ResourceSet<AccountResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieves a collection of Accounts belonging to the account used to make the request </summary>
        /// <param name="friendlyName"> Only return the Account resources with friendly names that exactly match this name. </param>
        /// <param name="status"> Only return Account resources with the given status. Can be `closed`, `suspended` or `active`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static ResourceSet<AccountResource> Read(
                                                     string friendlyName = null,
                                                     AccountResource.StatusEnum status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAccountOptions(){ FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieves a collection of Accounts belonging to the account used to make the request </summary>
        /// <param name="friendlyName"> Only return the Account resources with friendly names that exactly match this name. </param>
        /// <param name="status"> Only return Account resources with the given status. Can be `closed`, `suspended` or `active`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AccountResource>> ReadAsync(
                                                                                             string friendlyName = null,
                                                                                             AccountResource.StatusEnum status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAccountOptions(){ FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AccountResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AccountResource>.FromJson("accounts", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AccountResource> NextPage(Page<AccountResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AccountResource>.FromJson("accounts", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AccountResource> PreviousPage(Page<AccountResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AccountResource>.FromJson("accounts", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateAccountOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{Sid}.json";

            string PathSid = options.PathSid ?? client.AccountSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="options"> Update Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Update(UpdateAccountOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="options"> Update Account parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AccountResource> UpdateAsync(UpdateAccountOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="pathSid"> The Account Sid that uniquely identifies the account to update </param>
        /// <param name="friendlyName"> Update the human-readable description of this Account </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Account </returns>
        public static AccountResource Update(
                                          string pathSid = null,
                                          string friendlyName = null,
                                          AccountResource.StatusEnum status = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateAccountOptions(){ PathSid = pathSid, FriendlyName = friendlyName, Status = status };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="pathSid"> The Account Sid that uniquely identifies the account to update </param>
        /// <param name="friendlyName"> Update the human-readable description of this Account </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Account </returns>
        public static async System.Threading.Tasks.Task<AccountResource> UpdateAsync(
                                                                              string pathSid = null,
                                                                              string friendlyName = null,
                                                                              AccountResource.StatusEnum status = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateAccountOptions(){ PathSid = pathSid, FriendlyName = friendlyName, Status = status };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AccountResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AccountResource object represented by the provided JSON </returns>
        public static AccountResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AccountResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The authorization token for this account. This token should be kept a secret, so no sharing. </summary> 
        [JsonProperty("auth_token")]
        public string AuthToken { get; private set; }

        ///<summary> The date that this account was created, in GMT in RFC 2822 format </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this account was last updated, in GMT in RFC 2822 format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> A human readable description of this account, up to 64 characters long. By default the FriendlyName is your email address. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique 34 character id that represents the parent of this account. The OwnerAccountSid of a parent account is it's own sid. </summary> 
        [JsonProperty("owner_account_sid")]
        public string OwnerAccountSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        
        [JsonProperty("status")]
        public AccountResource.StatusEnum Status { get; private set; }

        ///<summary> A Map of various subresources available for the given Account Instance </summary> 
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        
        [JsonProperty("type")]
        public AccountResource.TypeEnum Type { get; private set; }

        ///<summary> The URI for this resource, relative to `https://api.twilio.com` </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private AccountResource() {

        }
    }
}
