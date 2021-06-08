using Newtonsoft.Json;

namespace DGC.Models
{
    public class RefreshPayload
    {

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public int data { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponseDTO error { get; set; }

        [JsonProperty("keyDuplicate")]
        public string keyDuplicate { get; set; }

        [JsonProperty("spanID")]
        public string spanID { get; set; }

        [JsonProperty("traceID")]
        public string traceID { get; set; }

    }
}