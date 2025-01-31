/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Verify
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



namespace Kandy.Rest.Verify.V2
{
    public class SafelistResource : Resource
    {



        private static Request BuildCreateRequest(CreateSafelistOptions options, IKandyRestClient client)
        {

            string path = "/v2/SafeList/Numbers";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Add a new phone number to SafeList. </summary>
        /// <param name="options"> Create Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static SafelistResource Create(CreateSafelistOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Add a new phone number to SafeList. </summary>
        /// <param name="options"> Create Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<SafelistResource> CreateAsync(CreateSafelistOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Add a new phone number to SafeList. </summary>
        /// <param name="phoneNumber"> The phone number to be added in SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static SafelistResource Create(
                                          string phoneNumber,
                                          IKandyRestClient client = null)
        {
            var options = new CreateSafelistOptions(phoneNumber) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Add a new phone number to SafeList. </summary>
        /// <param name="phoneNumber"> The phone number to be added in SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<SafelistResource> CreateAsync(
                                                                                  string phoneNumber,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateSafelistOptions(phoneNumber) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Remove a phone number from SafeList. </summary>
        /// <param name="options"> Delete Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        private static Request BuildDeleteRequest(DeleteSafelistOptions options, IKandyRestClient client)
        {

            string path = "/v2/SafeList/Numbers/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber;
            path = path.Replace("{" + "PhoneNumber" + "}", PathPhoneNumber);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove a phone number from SafeList. </summary>
        /// <param name="options"> Delete Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static bool Delete(DeleteSafelistOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Remove a phone number from SafeList. </summary>
        /// <param name="options"> Delete Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSafelistOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Remove a phone number from SafeList. </summary>
        /// <param name="pathPhoneNumber"> The phone number to be removed from SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static bool Delete(string pathPhoneNumber, IKandyRestClient client = null)
        {
            var options = new DeleteSafelistOptions(pathPhoneNumber);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Remove a phone number from SafeList. </summary>
        /// <param name="pathPhoneNumber"> The phone number to be removed from SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathPhoneNumber, IKandyRestClient client = null)
        {
            var options = new DeleteSafelistOptions(pathPhoneNumber);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchSafelistOptions options, IKandyRestClient client)
        {

            string path = "/v2/SafeList/Numbers/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber;
            path = path.Replace("{" + "PhoneNumber" + "}", PathPhoneNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Check if a phone number exists in SafeList. </summary>
        /// <param name="options"> Fetch Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static SafelistResource Fetch(FetchSafelistOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Check if a phone number exists in SafeList. </summary>
        /// <param name="options"> Fetch Safelist parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<SafelistResource> FetchAsync(FetchSafelistOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Check if a phone number exists in SafeList. </summary>
        /// <param name="pathPhoneNumber"> The phone number to be fetched from SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Safelist </returns>
        public static SafelistResource Fetch(
                                         string pathPhoneNumber,
                                         IKandyRestClient client = null)
        {
            var options = new FetchSafelistOptions(pathPhoneNumber) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Check if a phone number exists in SafeList. </summary>
        /// <param name="pathPhoneNumber"> The phone number to be fetched from SafeList. Phone numbers must be in [E.164 format](https://www.kandy.com/docs/glossary/what-e164). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Safelist </returns>
        public static async System.Threading.Tasks.Task<SafelistResource> FetchAsync(string pathPhoneNumber, IKandyRestClient client = null)
        {
            var options = new FetchSafelistOptions(pathPhoneNumber) { };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a SafelistResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SafelistResource object represented by the provided JSON </returns>
        public static SafelistResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SafelistResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the SafeList resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The phone number in SafeList. </summary> 
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        ///<summary> The absolute URL of the SafeList resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SafelistResource()
        {

        }
    }
}
