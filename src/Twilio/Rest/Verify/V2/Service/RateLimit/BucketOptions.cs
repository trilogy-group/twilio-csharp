/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service.RateLimit
{

    /// <summary> Create a new Bucket for a Rate Limit </summary>
    public class CreateBucketOptions : IOptions<BucketResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        public string PathRateLimitSid { get; }

        ///<summary> Maximum number of requests permitted in during the interval. </summary> 
        public int? Max { get; }

        ///<summary> Number of seconds that the rate limit will be enforced over. </summary> 
        public int? Interval { get; }


        /// <summary> Construct a new CreateBucketOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="max"> Maximum number of requests permitted in during the interval. </param>
        /// <param name="interval"> Number of seconds that the rate limit will be enforced over. </param>
        public CreateBucketOptions(string pathServiceSid, string pathRateLimitSid, int? max, int? interval)
        {
            PathServiceSid = pathServiceSid;
            PathRateLimitSid = pathRateLimitSid;
            Max = max;
            Interval = interval;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Max != null)
            {
                p.Add(new KeyValuePair<string, string>("Max", Max.ToString()));
            }
            if (Interval != null)
            {
                p.Add(new KeyValuePair<string, string>("Interval", Interval.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific Bucket. </summary>
    public class DeleteBucketOptions : IOptions<BucketResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        public string PathRateLimitSid { get; }

        ///<summary> A 34 character string that uniquely identifies this Bucket. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteBucketOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        public DeleteBucketOptions(string pathServiceSid, string pathRateLimitSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathRateLimitSid = pathRateLimitSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific Bucket. </summary>
    public class FetchBucketOptions : IOptions<BucketResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        public string PathRateLimitSid { get; }

        ///<summary> A 34 character string that uniquely identifies this Bucket. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchBucketOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        public FetchBucketOptions(string pathServiceSid, string pathRateLimitSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathRateLimitSid = pathRateLimitSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Buckets for a Rate Limit. </summary>
    public class ReadBucketOptions : ReadOptions<BucketResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        public string PathRateLimitSid { get; }



        /// <summary> Construct a new ListBucketOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        public ReadBucketOptions(string pathServiceSid, string pathRateLimitSid)
        {
            PathServiceSid = pathServiceSid;
            PathRateLimitSid = pathRateLimitSid;
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

    /// <summary> Update a specific Bucket. </summary>
    public class UpdateBucketOptions : IOptions<BucketResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        public string PathRateLimitSid { get; }

        ///<summary> A 34 character string that uniquely identifies this Bucket. </summary> 
        public string PathSid { get; }

        ///<summary> Maximum number of requests permitted in during the interval. </summary> 
        public int? Max { get; set; }

        ///<summary> Number of seconds that the rate limit will be enforced over. </summary> 
        public int? Interval { get; set; }



        /// <summary> Construct a new UpdateBucketOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        public UpdateBucketOptions(string pathServiceSid, string pathRateLimitSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathRateLimitSid = pathRateLimitSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Max != null)
            {
                p.Add(new KeyValuePair<string, string>("Max", Max.ToString()));
            }
            if (Interval != null)
            {
                p.Add(new KeyValuePair<string, string>("Interval", Interval.ToString()));
            }
            return p;
        }
        

    }


}

