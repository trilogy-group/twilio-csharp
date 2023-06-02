/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Video
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
using System.Linq;



namespace Kandy.Rest.Video.V1
{

    /// <summary> create </summary>
    public class CreateCompositionHookOptions : IOptions<CompositionHookResource>
    {

        ///<summary> A descriptive string that you create to describe the resource. It can be up to  100 characters long and it must be unique within the account. </summary> 
        public string FriendlyName { get; }

        ///<summary> Whether the composition hook is active. When `true`, the composition hook will be triggered for every completed Group Room in the account. When `false`, the composition hook will never be triggered. </summary> 
        public bool? Enabled { get; set; }

        ///<summary> An object that describes the video layout of the composition hook in terms of regions. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public object VideoLayout { get; set; }

        ///<summary> An array of track names from the same group room to merge into the compositions created by the composition hook. Can include zero or more track names. A composition triggered by the composition hook includes all audio sources specified in `audio_sources` except those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which matches zero or more characters in a track name. For example, `student*` includes tracks named `student` as well as `studentTeam`. </summary> 
        public List<string> AudioSources { get; set; }

        ///<summary> An array of track names to exclude. A composition triggered by the composition hook includes all audio sources specified in `audio_sources` except for those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which matches zero or more characters in a track name. For example, `student*` excludes `student` as well as `studentTeam`. This parameter can also be empty. </summary> 
        public List<string> AudioSourcesExcluded { get; set; }

        ///<summary> A string that describes the columns (width) and rows (height) of the generated composed video in pixels. Defaults to `640x480`.  The string's format is `{width}x{height}` where:   * 16 <= `{width}` <= 1280 * 16 <= `{height}` <= 1280 * `{width}` * `{height}` <= 921,600  Typical values are:   * HD = `1280x720` * PAL = `1024x576` * VGA = `640x480` * CIF = `320x240`  Note that the `resolution` imposes an aspect ratio to the resulting composition. When the original video tracks are constrained by the aspect ratio, they are scaled to fit. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public string Resolution { get; set; }


        public CompositionHookResource.FormatEnum Format { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application on every composition event. If not provided, status callback events will not be dispatched. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `POST` or `GET` and the default is `POST`. </summary> 
        public Kandy.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> Whether to clip the intervals where there is no active media in the Compositions triggered by the composition hook. The default is `true`. Compositions with `trim` enabled are shorter when the Room is created and no Participant joins for a while as well as if all the Participants leave the room and join later, because those gaps will be removed. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public bool? Trim { get; set; }


        /// <summary> Construct a new CreateCompositionHookOptions </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to  100 characters long and it must be unique within the account. </param>
        public CreateCompositionHookOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
            AudioSources = new List<string>();
            AudioSourcesExcluded = new List<string>();
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            if (VideoLayout != null)
            {
                p.Add(new KeyValuePair<string, string>("VideoLayout", Serializers.JsonObject(VideoLayout)));
            }
            if (AudioSources != null)
            {
                p.AddRange(AudioSources.Select(AudioSources => new KeyValuePair<string, string>("AudioSources", AudioSources)));
            }
            if (AudioSourcesExcluded != null)
            {
                p.AddRange(AudioSourcesExcluded.Select(AudioSourcesExcluded => new KeyValuePair<string, string>("AudioSourcesExcluded", AudioSourcesExcluded)));
            }
            if (Resolution != null)
            {
                p.Add(new KeyValuePair<string, string>("Resolution", Resolution));
            }
            if (Format != null)
            {
                p.Add(new KeyValuePair<string, string>("Format", Format.ToString()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.Value.ToString().ToLower()));
            }
            return p;
        }


    }
    /// <summary> Delete a Recording CompositionHook resource identified by a `CompositionHook SID`. </summary>
    public class DeleteCompositionHookOptions : IOptions<CompositionHookResource>
    {

        ///<summary> The SID of the CompositionHook resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteCompositionHookOptions </summary>
        /// <param name="pathSid"> The SID of the CompositionHook resource to delete. </param>
        public DeleteCompositionHookOptions(string pathSid)
        {
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Returns a single CompositionHook resource identified by a CompositionHook SID. </summary>
    public class FetchCompositionHookOptions : IOptions<CompositionHookResource>
    {

        ///<summary> The SID of the CompositionHook resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCompositionHookOptions </summary>
        /// <param name="pathSid"> The SID of the CompositionHook resource to fetch. </param>
        public FetchCompositionHookOptions(string pathSid)
        {
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> List of all Recording CompositionHook resources. </summary>
    public class ReadCompositionHookOptions : ReadOptions<CompositionHookResource>
    {

        ///<summary> Read only CompositionHook resources with an `enabled` value that matches this parameter. </summary> 
        public bool? Enabled { get; set; }

        ///<summary> Read only CompositionHook resources created on or after this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) datetime with time zone. </summary> 
        public DateTime? DateCreatedAfter { get; set; }

        ///<summary> Read only CompositionHook resources created before this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) datetime with time zone. </summary> 
        public DateTime? DateCreatedBefore { get; set; }

        ///<summary> Read only CompositionHook resources with friendly names that match this string. The match is not case sensitive and can include asterisk `*` characters as wildcard match. </summary> 
        public string FriendlyName { get; set; }





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }
            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

    /// <summary> update </summary>
    public class UpdateCompositionHookOptions : IOptions<CompositionHookResource>
    {

        ///<summary> The SID of the CompositionHook resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to  100 characters long and it must be unique within the account. </summary> 
        public string FriendlyName { get; }

        ///<summary> Whether the composition hook is active. When `true`, the composition hook will be triggered for every completed Group Room in the account. When `false`, the composition hook never triggers. </summary> 
        public bool? Enabled { get; set; }

        ///<summary> A JSON object that describes the video layout of the composition hook in terms of regions. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public object VideoLayout { get; set; }

        ///<summary> An array of track names from the same group room to merge into the compositions created by the composition hook. Can include zero or more track names. A composition triggered by the composition hook includes all audio sources specified in `audio_sources` except those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which matches zero or more characters in a track name. For example, `student*` includes tracks named `student` as well as `studentTeam`. </summary> 
        public List<string> AudioSources { get; set; }

        ///<summary> An array of track names to exclude. A composition triggered by the composition hook includes all audio sources specified in `audio_sources` except for those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which matches zero or more characters in a track name. For example, `student*` excludes `student` as well as `studentTeam`. This parameter can also be empty. </summary> 
        public List<string> AudioSourcesExcluded { get; set; }

        ///<summary> Whether to clip the intervals where there is no active media in the compositions triggered by the composition hook. The default is `true`. Compositions with `trim` enabled are shorter when the Room is created and no Participant joins for a while as well as if all the Participants leave the room and join later, because those gaps will be removed. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public bool? Trim { get; set; }


        public CompositionHookResource.FormatEnum Format { get; set; }

        ///<summary> A string that describes the columns (width) and rows (height) of the generated composed video in pixels. Defaults to `640x480`.  The string's format is `{width}x{height}` where:   * 16 <= `{width}` <= 1280 * 16 <= `{height}` <= 1280 * `{width}` * `{height}` <= 921,600  Typical values are:   * HD = `1280x720` * PAL = `1024x576` * VGA = `640x480` * CIF = `320x240`  Note that the `resolution` imposes an aspect ratio to the resulting composition. When the original video tracks are constrained by the aspect ratio, they are scaled to fit. See [Specifying Video Layouts](https://www.kandy.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public string Resolution { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application on every composition event. If not provided, status callback events will not be dispatched. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `POST` or `GET` and the default is `POST`. </summary> 
        public Kandy.Http.HttpMethod StatusCallbackMethod { get; set; }



        /// <summary> Construct a new UpdateCompositionHookOptions </summary>
        /// <param name="pathSid"> The SID of the CompositionHook resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to  100 characters long and it must be unique within the account. </param>
        public UpdateCompositionHookOptions(string pathSid, string friendlyName)
        {
            PathSid = pathSid;
            FriendlyName = friendlyName;
            AudioSources = new List<string>();
            AudioSourcesExcluded = new List<string>();
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            if (VideoLayout != null)
            {
                p.Add(new KeyValuePair<string, string>("VideoLayout", Serializers.JsonObject(VideoLayout)));
            }
            if (AudioSources != null)
            {
                p.AddRange(AudioSources.Select(AudioSources => new KeyValuePair<string, string>("AudioSources", AudioSources)));
            }
            if (AudioSourcesExcluded != null)
            {
                p.AddRange(AudioSourcesExcluded.Select(AudioSourcesExcluded => new KeyValuePair<string, string>("AudioSourcesExcluded", AudioSourcesExcluded)));
            }
            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.Value.ToString().ToLower()));
            }
            if (Format != null)
            {
                p.Add(new KeyValuePair<string, string>("Format", Format.ToString()));
            }
            if (Resolution != null)
            {
                p.Add(new KeyValuePair<string, string>("Resolution", Resolution));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            return p;
        }


    }


}
