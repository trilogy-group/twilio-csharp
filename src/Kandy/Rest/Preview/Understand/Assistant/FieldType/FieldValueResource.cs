/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Preview
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



namespace Kandy.Rest.Preview.Understand.Assistant.FieldType
{
    public class FieldValueResource : Resource
    {



        private static Request BuildCreateRequest(CreateFieldValueOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/FieldTypes/{FieldTypeSid}/FieldValues";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathFieldTypeSid = options.PathFieldTypeSid;
            path = path.Replace("{" + "FieldTypeSid" + "}", PathFieldTypeSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Create(CreateFieldValueOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> CreateAsync(CreateFieldValueOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="language"> An ISO language-country string of the value. </param>
        /// <param name="value"> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </param>
        /// <param name="synonymOf"> A value that indicates this field value is a synonym of. Empty if the value is not a synonym. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Create(
                                          string pathAssistantSid,
                                          string pathFieldTypeSid,
                                          string language,
                                          string value,
                                          string synonymOf = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateFieldValueOptions(pathAssistantSid, pathFieldTypeSid, language, value) { SynonymOf = synonymOf };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="language"> An ISO language-country string of the value. </param>
        /// <param name="value"> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </param>
        /// <param name="synonymOf"> A value that indicates this field value is a synonym of. Empty if the value is not a synonym. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> CreateAsync(
                                                                                  string pathAssistantSid,
                                                                                  string pathFieldTypeSid,
                                                                                  string language,
                                                                                  string value,
                                                                                  string synonymOf = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateFieldValueOptions(pathAssistantSid, pathFieldTypeSid, language, value) { SynonymOf = synonymOf };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        private static Request BuildDeleteRequest(DeleteFieldValueOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/FieldTypes/{FieldTypeSid}/FieldValues/{Sid}";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathFieldTypeSid = options.PathFieldTypeSid;
            path = path.Replace("{" + "FieldTypeSid" + "}", PathFieldTypeSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static bool Delete(DeleteFieldValueOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFieldValueOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static bool Delete(string pathAssistantSid, string pathFieldTypeSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid, string pathFieldTypeSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchFieldValueOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/FieldTypes/{FieldTypeSid}/FieldValues/{Sid}";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathFieldTypeSid = options.PathFieldTypeSid;
            path = path.Replace("{" + "FieldTypeSid" + "}", PathFieldTypeSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Fetch(FetchFieldValueOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> FetchAsync(FetchFieldValueOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Fetch(
                                         string pathAssistantSid,
                                         string pathFieldTypeSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> FetchAsync(string pathAssistantSid, string pathFieldTypeSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadFieldValueOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/FieldTypes/{FieldTypeSid}/FieldValues";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathFieldTypeSid = options.PathFieldTypeSid;
            path = path.Replace("{" + "FieldTypeSid" + "}", PathFieldTypeSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static ResourceSet<FieldValueResource> Read(ReadFieldValueOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FieldValueResource>.FromJson("field_values", response.Content);
            return new ResourceSet<FieldValueResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldValueResource>> ReadAsync(ReadFieldValueOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FieldValueResource>.FromJson("field_values", response.Content);
            return new ResourceSet<FieldValueResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="language"> An ISO language-country string of the value. For example: *en-US* </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of FieldValue </returns>
        public static ResourceSet<FieldValueResource> Read(
                                                     string pathAssistantSid,
                                                     string pathFieldTypeSid,
                                                     string language = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadFieldValueOptions(pathAssistantSid, pathFieldTypeSid) { Language = language, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="language"> An ISO language-country string of the value. For example: *en-US* </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldValueResource>> ReadAsync(
                                                                                             string pathAssistantSid,
                                                                                             string pathFieldTypeSid,
                                                                                             string language = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadFieldValueOptions(pathAssistantSid, pathFieldTypeSid) { Language = language, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<FieldValueResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<FieldValueResource> NextPage(Page<FieldValueResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<FieldValueResource> PreviousPage(Page<FieldValueResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a FieldValueResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FieldValueResource object represented by the provided JSON </returns>
        public static FieldValueResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FieldValueResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique ID of the Account that created this Field Value. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date that this resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The unique ID of the Field Type associated with this Field Value. </summary> 
        [JsonProperty("field_type_sid")]
        public string FieldTypeSid { get; private set; }

        ///<summary> An ISO language-country string of the value. </summary> 
        [JsonProperty("language")]
        public string Language { get; private set; }

        ///<summary> The unique ID of the Assistant. </summary> 
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The Field Value itself. </summary> 
        [JsonProperty("value")]
        public string Value { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> A value that indicates this field value is a synonym of. Empty if the value is not a synonym. </summary> 
        [JsonProperty("synonym_of")]
        public string SynonymOf { get; private set; }



        private FieldValueResource()
        {

        }
    }
}
