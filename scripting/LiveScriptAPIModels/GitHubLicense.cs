using Newtonsoft.Json;

namespace scripting.LiveScriptAPIModels
{
    public class GitHubLicense
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spdx_id")]
        public string SPDXId { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }
    }
}