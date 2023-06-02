/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Messaging
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



namespace Kandy.Rest.Messaging.V1
{
    public class UsecaseResource : Resource
    {



        private static Request BuildFetchRequest(FetchUsecaseOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/Usecases";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Usecase parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Usecase </returns>
        public static UsecaseResource Fetch(FetchUsecaseOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Usecase parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Usecase </returns>
        public static async System.Threading.Tasks.Task<UsecaseResource> FetchAsync(FetchUsecaseOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Usecase </returns>
        public static UsecaseResource Fetch(
                                         IKandyRestClient client = null)
        {
            var options = new FetchUsecaseOptions() { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Usecase </returns>
        public static async System.Threading.Tasks.Task<UsecaseResource> FetchAsync(IKandyRestClient client = null)
        {
            var options = new FetchUsecaseOptions() { };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a UsecaseResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsecaseResource object represented by the provided JSON </returns>
        public static UsecaseResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UsecaseResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> Human readable use case details (usecase, description and purpose) of Messaging Service Use Cases. </summary> 
        [JsonProperty("usecases")]
        public List<object> Usecases { get; private set; }



        private UsecaseResource()
        {

        }
    }
}
