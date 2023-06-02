/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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


namespace Kandy.Rest.Studio.V2
{
    public class FlowValidateResource : Resource
    {

        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) { }
            public StatusEnum() { }
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum Published = new StatusEnum("published");

        }


        private static Request BuildUpdateRequest(UpdateFlowValidateOptions options, IKandyRestClient client)
        {

            string path = "/v2/Flows/Validate";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Validate flow JSON definition </summary>
        /// <param name="options"> Update FlowValidate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowValidate </returns>
        public static FlowValidateResource Update(UpdateFlowValidateOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Validate flow JSON definition </summary>
        /// <param name="options"> Update FlowValidate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowValidate </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<FlowValidateResource> UpdateAsync(UpdateFlowValidateOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Validate flow JSON definition </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the Flow. </param>
        /// <param name="status">  </param>
        /// <param name="definition"> JSON representation of flow definition. </param>
        /// <param name="commitMessage"> Description of change made in the revision. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowValidate </returns>
        public static FlowValidateResource Update(
                                          string friendlyName,
                                          FlowValidateResource.StatusEnum status,
                                          object definition,
                                          string commitMessage = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateFlowValidateOptions(friendlyName, status, definition) { CommitMessage = commitMessage };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Validate flow JSON definition </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the Flow. </param>
        /// <param name="status">  </param>
        /// <param name="definition"> JSON representation of flow definition. </param>
        /// <param name="commitMessage"> Description of change made in the revision. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowValidate </returns>
        public static async System.Threading.Tasks.Task<FlowValidateResource> UpdateAsync(
                                                                              string friendlyName,
                                                                              FlowValidateResource.StatusEnum status,
                                                                              object definition,
                                                                              string commitMessage = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateFlowValidateOptions(friendlyName, status, definition) { CommitMessage = commitMessage };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a FlowValidateResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FlowValidateResource object represented by the provided JSON </returns>
        public static FlowValidateResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FlowValidateResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> Boolean if the flow definition is valid. </summary> 
        [JsonProperty("valid")]
        public bool? Valid { get; private set; }



        private FlowValidateResource()
        {

        }
    }
}
