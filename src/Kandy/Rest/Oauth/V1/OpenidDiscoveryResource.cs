/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Oauth
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



namespace Kandy.Rest.Oauth.V1
{
    public class OpenidDiscoveryResource : Resource
    {



        private static Request BuildFetchRequest(FetchOpenidDiscoveryOptions options, IKandyRestClient client)
        {

            string path = "/v1/.well-known/openid-configuration";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Oauth,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="options"> Fetch OpenidDiscovery parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of OpenidDiscovery </returns>
        public static OpenidDiscoveryResource Fetch(FetchOpenidDiscoveryOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="options"> Fetch OpenidDiscovery parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of OpenidDiscovery </returns>
        public static async System.Threading.Tasks.Task<OpenidDiscoveryResource> FetchAsync(FetchOpenidDiscoveryOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of OpenidDiscovery </returns>
        public static OpenidDiscoveryResource Fetch(
                                         IKandyRestClient client = null)
        {
            var options = new FetchOpenidDiscoveryOptions() { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of OpenidDiscovery </returns>
        public static async System.Threading.Tasks.Task<OpenidDiscoveryResource> FetchAsync(IKandyRestClient client = null)
        {
            var options = new FetchOpenidDiscoveryOptions() { };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a OpenidDiscoveryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> OpenidDiscoveryResource object represented by the provided JSON </returns>
        public static OpenidDiscoveryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<OpenidDiscoveryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The URL of the party that will create the token and sign it with its private key. </summary> 
        [JsonProperty("issuer")]
        public Uri Issuer { get; private set; }

        ///<summary> The endpoint that validates all authorization requests. </summary> 
        [JsonProperty("authorization_endpoint")]
        public Uri AuthorizationEndpoint { get; private set; }

        ///<summary> The endpoint that validates all device code related authorization requests. </summary> 
        [JsonProperty("device_authorization_endpoint")]
        public Uri DeviceAuthorizationEndpoint { get; private set; }

        ///<summary> The URL of the token endpoint. After a client has received an authorization code, that code is presented to the token endpoint and exchanged for an identity token, an access token, and a refresh token. </summary> 
        [JsonProperty("token_endpoint")]
        public Uri TokenEndpoint { get; private set; }

        ///<summary> The URL of the user info endpoint, which returns user profile information to a client. Keep in mind that the user info endpoint returns only the information that has been requested. </summary> 
        [JsonProperty("userinfo_endpoint")]
        public Uri UserinfoEndpoint { get; private set; }

        ///<summary> The endpoint used to revoke access or refresh tokens issued by the authorization server. </summary> 
        [JsonProperty("revocation_endpoint")]
        public Uri RevocationEndpoint { get; private set; }

        ///<summary> The URL of your JSON Web Key Set. This set is a collection of JSON Web Keys, a standard method for representing cryptographic keys in a JSON structure. </summary> 
        [JsonProperty("jwk_uri")]
        public Uri JwkUri { get; private set; }

        ///<summary> A collection of response type supported by authorization server. </summary> 
        [JsonProperty("response_type_supported")]
        public List<string> ResponseTypeSupported { get; private set; }

        ///<summary> A collection of subject by authorization server. </summary> 
        [JsonProperty("subject_type_supported")]
        public List<string> SubjectTypeSupported { get; private set; }

        ///<summary> A collection of JWS signing algorithms supported by authorization server to sign identity token. </summary> 
        [JsonProperty("id_token_signing_alg_values_supported")]
        public List<string> IdTokenSigningAlgValuesSupported { get; private set; }

        ///<summary> A collection of scopes supported by authorization server for identity token </summary> 
        [JsonProperty("scopes_supported")]
        public List<string> ScopesSupported { get; private set; }

        ///<summary> A collection of claims supported by authorization server for identity token </summary> 
        [JsonProperty("claims_supported")]
        public List<string> ClaimsSupported { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private OpenidDiscoveryResource()
        {

        }
    }
}
