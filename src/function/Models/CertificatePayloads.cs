using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DGC.Models
{
    public class CertificatePayloads
    {

        [JsonProperty("payloads")]
        public List<CertificatePayload> PayloadList { get; set; }

    }

}