using Newtonsoft.Json;

namespace DGC.Models
{
    public class QrCodeInfoDTO
    {

        [JsonProperty("qrcodeB64")]
        public string qrcodeB64 { get; set; }

        [JsonProperty("uvci")]
        public string uvci { get; set; }

    }
}