using Newtonsoft.Json;

namespace DGC.Models
{
    public class ErrorResponseDTO
    {

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string message { get; set; }

    }
}