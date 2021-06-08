using Newtonsoft.Json;

namespace DGC.Models
{
    public class QrCodeInfoDTO
    {

        [JsonProperty("qrcodeB64",NullValueHandling = NullValueHandling.Ignore)]
        public string qrcodeB64 { get; set; }

        
        [JsonProperty("uvci",NullValueHandling = NullValueHandling.Ignore)]
        public string uvci { get; set; }

    }
}