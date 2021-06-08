using Newtonsoft.Json;

namespace DGC.Models
{
    public class CertificatePayload
    {

        [JsonProperty("data")]
        public QrCodeInfoDTO data { get; set; }

        [JsonProperty("error")]
        public ErrorResponseDTO error { get; set; }

        [JsonProperty("keyDuplicate")]
        public string keyDuplicate { get; set; }

        [JsonProperty("spanID")]
        public string spanID { get; set; }

        [JsonProperty("traceID")]
        public string traceID { get; set; }

    }
}