using System.Collections.Generic;
using Newtonsoft.Json;
using Kandy.Converters;

/// <summary>
/// Subscribe Rule Update - Used to update the list of Subscribe Rules
///
///   For more information see:
///   <a href="https://www.kandy.com/docs/video/api/track-subscriptions#specifying-sr">Specifying Subscribe Rules</a>
/// </summary>
namespace Kandy.Types
{
    public class SubscribeRulesUpdate
    {
        [JsonProperty("rules")]
        public List<SubscribeRule> Rules { get; private set; }

        public SubscribeRulesUpdate(
            [JsonProperty("rules")]
            List<SubscribeRule> rules
        )
        {
            Rules = rules;
        }
    }
}
