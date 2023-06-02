/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Sync
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Kandy.Rest.Sync.V1.Service
{

    /// <summary> create </summary>
    public class CreateDocumentOptions : IOptions<DocumentResource>
    {
        
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the new Document resource in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> An application-defined string that uniquely identifies the Sync Document </summary> 
        public string UniqueName { get; set; }

        ///<summary> A JSON string that represents an arbitrary, schema-less object that the Sync Document stores. Can be up to 16 KiB in length. </summary> 
        public object Data { get; set; }

        ///<summary> How long, [in seconds](https://www.twilio.com/docs/sync/limits#sync-payload-limits), before the Sync Document expires and is deleted (the Sync Document's time-to-live). </summary> 
        public int? Ttl { get; set; }


        /// <summary> Construct a new CreateDocumentOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the new Document resource in. </param>
        public CreateDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }
            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteDocumentOptions : IOptions<DocumentResource>
    {
        
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to delete. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Document resource to delete. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteDocumentOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to delete. </param>
        /// <param name="pathSid"> The SID of the Document resource to delete. Can be the Document resource's `sid` or its `unique_name`. </param>
        public DeleteDocumentOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchDocumentOptions : IOptions<DocumentResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to fetch. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Document resource to fetch. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchDocumentOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to fetch. </param>
        /// <param name="pathSid"> The SID of the Document resource to fetch. Can be the Document resource's `sid` or its `unique_name`. </param>
        public FetchDocumentOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadDocumentOptions : ReadOptions<DocumentResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resources to read. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListDocumentOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resources to read. </param>
        public ReadDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateDocumentOptions : IOptions<DocumentResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to update. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Document resource to update. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }

        ///<summary> A JSON string that represents an arbitrary, schema-less object that the Sync Document stores. Can be up to 16 KiB in length. </summary> 
        public object Data { get; set; }

        ///<summary> How long, [in seconds](https://www.twilio.com/docs/sync/limits#sync-payload-limits), before the Sync Document expires and is deleted (time-to-live). </summary> 
        public int? Ttl { get; set; }



        /// <summary> Construct a new UpdateDocumentOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Document resource to update. </param>
        /// <param name="pathSid"> The SID of the Document resource to update. Can be the Document resource's `sid` or its `unique_name`. </param>
        public UpdateDocumentOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }
            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (IfMatch != null)
        {
            p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
        }
        return p;
    }

    }


}
