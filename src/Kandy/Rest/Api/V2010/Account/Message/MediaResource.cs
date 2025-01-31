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



namespace Kandy.Rest.Api.V2010.Account.Message
{
    public class MediaResource : Resource
    {



        /// <summary> Delete media from your account. Once delete, you will no longer be billed </summary>
        /// <param name="options"> Delete Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        private static Request BuildDeleteRequest(DeleteMediaOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Messages/{MessageSid}/Media/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathMessageSid = options.PathMessageSid;
            path = path.Replace("{" + "MessageSid" + "}", PathMessageSid);
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

        /// <summary> Delete media from your account. Once delete, you will no longer be billed </summary>
        /// <param name="options"> Delete Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static bool Delete(DeleteMediaOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete media from your account. Once delete, you will no longer be billed </summary>
        /// <param name="options"> Delete Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMediaOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete media from your account. Once delete, you will no longer be billed </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Media resource to delete </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static bool Delete(string pathMessageSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteMediaOptions(pathMessageSid, pathSid) { PathAccountSid = pathAccountSid };
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete media from your account. Once delete, you will no longer be billed </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Media resource to delete </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathMessageSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteMediaOptions(pathMessageSid, pathSid) { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchMediaOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Messages/{MessageSid}/Media/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathMessageSid = options.PathMessageSid;
            path = path.Replace("{" + "MessageSid" + "}", PathMessageSid);
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

        /// <summary> Fetch a single media instance belonging to the account used to make the request </summary>
        /// <param name="options"> Fetch Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static MediaResource Fetch(FetchMediaOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a single media instance belonging to the account used to make the request </summary>
        /// <param name="options"> Fetch Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<MediaResource> FetchAsync(FetchMediaOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a single media instance belonging to the account used to make the request </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Media resource to fetch </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static MediaResource Fetch(
                                         string pathMessageSid,
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchMediaOptions(pathMessageSid, pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a single media instance belonging to the account used to make the request </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Media resource to fetch </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<MediaResource> FetchAsync(string pathMessageSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchMediaOptions(pathMessageSid, pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadMediaOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Messages/{MessageSid}/Media.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathMessageSid = options.PathMessageSid;
            path = path.Replace("{" + "MessageSid" + "}", PathMessageSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Media resources belonging to the account used to make the request </summary>
        /// <param name="options"> Read Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static ResourceSet<MediaResource> Read(ReadMediaOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<MediaResource>.FromJson("media_list", response.Content);
            return new ResourceSet<MediaResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Media resources belonging to the account used to make the request </summary>
        /// <param name="options"> Read Media parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaResource>> ReadAsync(ReadMediaOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MediaResource>.FromJson("media_list", response.Content);
            return new ResourceSet<MediaResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of Media resources belonging to the account used to make the request </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to read. </param>
        /// <param name="dateCreatedBefore"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="dateCreated"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="dateCreatedAfter"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Media </returns>
        public static ResourceSet<MediaResource> Read(
                                                     string pathMessageSid,
                                                     string pathAccountSid = null,
                                                     DateTime? dateCreatedBefore = null,
                                                     DateTime? dateCreated = null,
                                                     DateTime? dateCreatedAfter = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadMediaOptions(pathMessageSid) { PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Media resources belonging to the account used to make the request </summary>
        /// <param name="pathMessageSid"> The SID of the Message resource that this Media resource belongs to. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Media resource(s) to read. </param>
        /// <param name="dateCreatedBefore"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="dateCreated"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="dateCreatedAfter"> Only include media that was created on this date. Specify a date as `YYYY-MM-DD` in GMT, for example: `2009-07-06`, to read media that was created on this date. You can also specify an inequality, such as `StartTime<=YYYY-MM-DD`, to read media that was created on or before midnight of this date, and `StartTime>=YYYY-MM-DD` to read media that was created on or after midnight of this date. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Media </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaResource>> ReadAsync(
                                                                                             string pathMessageSid,
                                                                                             string pathAccountSid = null,
                                                                                             DateTime? dateCreatedBefore = null,
                                                                                             DateTime? dateCreated = null,
                                                                                             DateTime? dateCreatedAfter = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadMediaOptions(pathMessageSid) { PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<MediaResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MediaResource>.FromJson("media_list", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<MediaResource> NextPage(Page<MediaResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaResource>.FromJson("media_list", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<MediaResource> PreviousPage(Page<MediaResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaResource>.FromJson("media_list", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a MediaResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MediaResource object represented by the provided JSON </returns>
        public static MediaResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MediaResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created this Media resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The default [mime-type](https://en.wikipedia.org/wiki/Internet_media_type) of the media, for example `image/jpeg`, `image/png`, or `image/gif` </summary> 
        [JsonProperty("content_type")]
        public string ContentType { get; private set; }

        ///<summary> The date and time in GMT that this resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that this resource was last updated, specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The SID of the resource that created the media. </summary> 
        [JsonProperty("parent_sid")]
        public string ParentSid { get; private set; }

        ///<summary> The unique string that that we created to identify this Media resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The URI of this resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private MediaResource()
        {

        }
    }
}
