using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace function.Models
{
    public class Payloads
    {
        [JsonProperty("payloads")]
        public List<Payload> PayloadList { get; set; }
    }

    public class Nam
    {
        [JsonProperty("fn")]
        public string Fn { get; set; }

        [JsonProperty("fnt")]
        public string Fnt { get; set; }

        [JsonProperty("gn")]
        public string Gn { get; set; }

        [JsonProperty("gnt")]
        public string Gnt { get; set; }
    }

    public class V
    {
        [JsonProperty("tg")]
        public string Tg { get; set; }

        [JsonProperty("vp")]
        public string Vp { get; set; }

        [JsonProperty("mp")]
        public string Mp { get; set; }

        [JsonProperty("ma")]
        public string Ma { get; set; }

        [JsonProperty("dn")]
        public int Dn { get; set; }

        [JsonProperty("sd")]
        public int Sd { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("co")]
        public string Co { get; set; }

        [JsonProperty("is")]
        public string Is { get; set; }

        [JsonProperty("ci")]
        public string Ci { get; set; }
    }

    public class T
    {
        [JsonProperty("tg")]
        public string Tg { get; set; }

        [JsonProperty("tt")]
        public string Tt { get; set; }

        [JsonProperty("nm")]
        public string Nm { get; set; }

        [JsonProperty("ma")]
        public string Ma { get; set; }

        [JsonProperty("sc")]
        public DateTime Sc { get; set; }

        [JsonProperty("dr")]
        public DateTime Dr { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }

        [JsonProperty("tc")]
        public string Tc { get; set; }

        [JsonProperty("co")]
        public string Co { get; set; }

        [JsonProperty("is")]
        public string Is { get; set; }

        [JsonProperty("ci")]
        public string Ci { get; set; }
    }

    public class R
    {
        [JsonProperty("tg")]
        public string Tg { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("co")]
        public string Co { get; set; }

        [JsonProperty("is")]
        public string Is { get; set; }

        [JsonProperty("df")]
        public string Df { get; set; }

        [JsonProperty("du")]
        public string Du { get; set; }

        [JsonProperty("ci")]
        public string Ci { get; set; }
    }

    public class JSON
    {
        [JsonProperty("ver")]
        public string Ver { get; set; }

        [JsonProperty("nam")]
        public Nam Nam { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("v")]
        public List<V> V { get; set; }

        [JsonProperty("t")]
        public List<T> T { get; set; }

        [JsonProperty("r")]
        public List<R> R { get; set; }
    }

    public class TESTCTX
    {
        [JsonProperty("VERSION")]
        public int VERSION { get; set; }

        [JsonProperty("SCHEMA")]
        public string SCHEMA { get; set; }

        [JsonProperty("CERTIFICATE")]
        public string CERTIFICATE { get; set; }

        [JsonProperty("VALIDATIONCLOCK")]
        public DateTime VALIDATIONCLOCK { get; set; }

        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
    }

    public class EXPECTEDRESULTS
    {
        [JsonProperty("EXPECTEDVALIDOBJECT")]
        public bool EXPECTEDVALIDOBJECT { get; set; }

        [JsonProperty("EXPECTEDSCHEMAVALIDATION")]
        public bool EXPECTEDSCHEMAVALIDATION { get; set; }

        [JsonProperty("EXPECTEDENCODE")]
        public bool EXPECTEDENCODE { get; set; }

        [JsonProperty("EXPECTEDDECODE")]
        public bool EXPECTEDDECODE { get; set; }

        [JsonProperty("EXPECTEDVERIFY")]
        public bool EXPECTEDVERIFY { get; set; }

        [JsonProperty("EXPECTEDCOMPRESSION")]
        public bool EXPECTEDCOMPRESSION { get; set; }

        [JsonProperty("EXPECTEDKEYUSAGE")]
        public bool EXPECTEDKEYUSAGE { get; set; }

        [JsonProperty("EXPECTEDUNPREFIX")]
        public bool EXPECTEDUNPREFIX { get; set; }

        [JsonProperty("EXPECTEDVALIDJSON")]
        public bool EXPECTEDVALIDJSON { get; set; }

        [JsonProperty("EXPECTEDB45DECODE")]
        public bool EXPECTEDB45DECODE { get; set; }

        [JsonProperty("EXPECTEDPICTUREDECODE")]
        public bool EXPECTEDPICTUREDECODE { get; set; }

        [JsonProperty("EXPECTEDEXPIRATIONCHECK")]
        public bool EXPECTEDEXPIRATIONCHECK { get; set; }
    }

    public class Payload
    {
        [JsonProperty("JSON")]
        public JSON JSON { get; set; }

        [JsonProperty("CBOR")]
        public string CBOR { get; set; }

        [JsonProperty("COSE")]
        public string COSE { get; set; }

        [JsonProperty("COMPRESSED")]
        public string COMPRESSED { get; set; }

        [JsonProperty("BASE45")]
        public string BASE45 { get; set; }

        [JsonProperty("PREFIX")]
        public string PREFIX { get; set; }

        [JsonProperty("2DCODE")]
        public string _2DCODE { get; set; }

        [JsonProperty("TESTCTX")]
        public TESTCTX TESTCTX { get; set; }

        [JsonProperty("EXPECTEDRESULTS")]
        public EXPECTEDRESULTS EXPECTEDRESULTS { get; set; }
    }

}