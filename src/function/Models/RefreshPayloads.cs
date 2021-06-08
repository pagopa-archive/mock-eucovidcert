using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DGC.Models
{
    public class RefreshPayloads
    {

        [JsonProperty("payloads")]
        public List<RefreshPayload> PayloadList { get; set; }

    }

}