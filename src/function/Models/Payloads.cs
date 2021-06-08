using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DGC.Models
{
    public class Payloads
    {

        [JsonProperty("payloads")]
        public List<Payload> PayloadList { get; set; }

    }

    public class Payload
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

    public class QrCodeInfoDTO
    {

        [JsonProperty("qrcodeB64")]
        public string qrcodeB64 { get; set; }

        [JsonProperty("uvci")]
        public string uvci { get; set; }

    }

    public class ErrorResponseDTO
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

    }

}