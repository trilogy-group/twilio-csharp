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


using System;
using System.Collections.Generic;
using Kandy.Base;
using Kandy.Converters;




namespace Kandy.Rest.Events.V1
{
    /// <summary> Fetch a specific schema with its nested versions. </summary>
    public class FetchSchemaOptions : IOptions<SchemaResource>
    {

        ///<summary> The unique identifier of the schema. Each schema can have multiple versions, that share the same id. </summary> 
        public string PathId { get; }



        /// <summary> Construct a new FetchSchemaOptions </summary>
        /// <param name="pathId"> The unique identifier of the schema. Each schema can have multiple versions, that share the same id. </param>
        public FetchSchemaOptions(string pathId)
        {
            PathId = pathId;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


}
