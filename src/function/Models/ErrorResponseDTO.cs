using Newtonsoft.Json;

namespace DGC.Models
{
    public class ErrorResponseDTO
    {

        [JsonProperty("code")]
        public int code { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

    }
}