using Newtonsoft.Json;

namespace DGC.Models
{
    public class CertificatePayload
    {

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public QrCodeInfoDTO data { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponseDTO error { get; set; }

        [JsonProperty("keyDuplicate",NullValueHandling = NullValueHandling.Ignore)]
        public string keyDuplicate { get; set; }

        [JsonProperty("spanID",NullValueHandling = NullValueHandling.Ignore)]
        public string spanID { get; set; }

        [JsonProperty("traceID",NullValueHandling = NullValueHandling.Ignore)]
        public string traceID { get; set; }

    }
}