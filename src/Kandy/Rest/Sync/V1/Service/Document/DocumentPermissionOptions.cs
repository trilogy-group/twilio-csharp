/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Sync
 * This is the public Kandy REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Kandy.Base;
using Kandy.Converters;




namespace Kandy.Rest.Sync.V1.Service.Document
{
    /// <summary> Delete a specific Sync Document Permission. </summary>
    public class DeleteDocumentPermissionOptions : IOptions<DocumentPermissionResource>
    {

        ///<summary> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to delete. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Document with the Document Permission resource to delete. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathDocumentSid { get; }

        ///<summary> The application-defined string that uniquely identifies the User's Document Permission resource to delete. </summary> 
        public string PathIdentity { get; }



        /// <summary> Construct a new DeleteDocumentPermissionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to delete. </param>
        /// <param name="pathDocumentSid"> The SID of the Sync Document with the Document Permission resource to delete. Can be the Document resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Document Permission resource to delete. </param>
        public DeleteDocumentPermissionOptions(string pathServiceSid, string pathDocumentSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathDocumentSid = pathDocumentSid;
            PathIdentity = pathIdentity;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Fetch a specific Sync Document Permission. </summary>
    public class FetchDocumentPermissionOptions : IOptions<DocumentPermissionResource>
    {

        ///<summary> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to fetch. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Document with the Document Permission resource to fetch. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathDocumentSid { get; }

        ///<summary> The application-defined string that uniquely identifies the User's Document Permission resource to fetch. </summary> 
        public string PathIdentity { get; }



        /// <summary> Construct a new FetchDocumentPermissionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to fetch. </param>
        /// <param name="pathDocumentSid"> The SID of the Sync Document with the Document Permission resource to fetch. Can be the Document resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Document Permission resource to fetch. </param>
        public FetchDocumentPermissionOptions(string pathServiceSid, string pathDocumentSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathDocumentSid = pathDocumentSid;
            PathIdentity = pathIdentity;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Retrieve a list of all Permissions applying to a Sync Document. </summary>
    public class ReadDocumentPermissionOptions : ReadOptions<DocumentPermissionResource>
    {

        ///<summary> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resources to read. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Document with the Document Permission resources to read. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathDocumentSid { get; }



        /// <summary> Construct a new ListDocumentPermissionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resources to read. </param>
        /// <param name="pathDocumentSid"> The SID of the Sync Document with the Document Permission resources to read. Can be the Document resource's `sid` or its `unique_name`. </param>
        public ReadDocumentPermissionOptions(string pathServiceSid, string pathDocumentSid)
        {
            PathServiceSid = pathServiceSid;
            PathDocumentSid = pathDocumentSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

    /// <summary> Update an identity's access to a specific Sync Document. </summary>
    public class UpdateDocumentPermissionOptions : IOptions<DocumentPermissionResource>
    {

        ///<summary> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to update. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Document with the Document Permission resource to update. Can be the Document resource's `sid` or its `unique_name`. </summary> 
        public string PathDocumentSid { get; }

        ///<summary> The application-defined string that uniquely identifies the User's Document Permission resource to update. </summary> 
        public string PathIdentity { get; }

        ///<summary> Whether the identity can read the Sync Document. Default value is `false`. </summary> 
        public bool? Read { get; }

        ///<summary> Whether the identity can update the Sync Document. Default value is `false`. </summary> 
        public bool? Write { get; }

        ///<summary> Whether the identity can delete the Sync Document. Default value is `false`. </summary> 
        public bool? Manage { get; }



        /// <summary> Construct a new UpdateDocumentPermissionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Document Permission resource to update. </param>
        /// <param name="pathDocumentSid"> The SID of the Sync Document with the Document Permission resource to update. Can be the Document resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Document Permission resource to update. </param>
        /// <param name="read"> Whether the identity can read the Sync Document. Default value is `false`. </param>
        /// <param name="write"> Whether the identity can update the Sync Document. Default value is `false`. </param>
        /// <param name="manage"> Whether the identity can delete the Sync Document. Default value is `false`. </param>
        public UpdateDocumentPermissionOptions(string pathServiceSid, string pathDocumentSid, string pathIdentity, bool? read, bool? write, bool? manage)
        {
            PathServiceSid = pathServiceSid;
            PathDocumentSid = pathDocumentSid;
            PathIdentity = pathIdentity;
            Read = read;
            Write = write;
            Manage = manage;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Read != null)
            {
                p.Add(new KeyValuePair<string, string>("Read", Read.Value.ToString().ToLower()));
            }
            if (Write != null)
            {
                p.Add(new KeyValuePair<string, string>("Write", Write.Value.ToString().ToLower()));
            }
            if (Manage != null)
            {
                p.Add(new KeyValuePair<string, string>("Manage", Manage.Value.ToString().ToLower()));
            }
            return p;
        }


    }


}
