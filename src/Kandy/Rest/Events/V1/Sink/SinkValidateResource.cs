/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Events
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



namespace Kandy.Rest.Events.V1.Sink
{
    public class SinkValidateResource : Resource
    {



        private static Request BuildCreateRequest(CreateSinkValidateOptions options, IKandyRestClient client)
        {

            string path = "/v1/Sinks/{Sid}/Validate";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Validate that a test event for a Sink was received. </summary>
        /// <param name="options"> Create SinkValidate parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SinkValidate </returns>
        public static SinkValidateResource Create(CreateSinkValidateOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Validate that a test event for a Sink was received. </summary>
        /// <param name="options"> Create SinkValidate parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SinkValidate </returns>
        public static async System.Threading.Tasks.Task<SinkValidateResource> CreateAsync(CreateSinkValidateOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Validate that a test event for a Sink was received. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Sink being validated. </param>
        /// <param name="testId"> A 34 character string that uniquely identifies the test event for a Sink being validated. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SinkValidate </returns>
        public static SinkValidateResource Create(
                                          string pathSid,
                                          string testId,
                                          IKandyRestClient client = null)
        {
            var options = new CreateSinkValidateOptions(pathSid, testId) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Validate that a test event for a Sink was received. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Sink being validated. </param>
        /// <param name="testId"> A 34 character string that uniquely identifies the test event for a Sink being validated. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SinkValidate </returns>
        public static async System.Threading.Tasks.Task<SinkValidateResource> CreateAsync(
                                                                                  string pathSid,
                                                                                  string testId,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateSinkValidateOptions(pathSid, testId) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a SinkValidateResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SinkValidateResource object represented by the provided JSON </returns>
        public static SinkValidateResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SinkValidateResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> Feedback indicating whether the given Sink was validated. </summary> 
        [JsonProperty("result")]
        public string Result { get; private set; }



        private SinkValidateResource()
        {

        }
    }
}
