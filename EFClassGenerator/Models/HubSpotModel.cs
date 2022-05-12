using Newtonsoft.Json;

namespace EFClassGenerator.Models
{
    public class HubSpotModel
    {
        [JsonProperty(PropertyName = "name")]
        public string DbColumnName { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string DbColumnAlias { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string DbColumnType { get; set; }
    }
}