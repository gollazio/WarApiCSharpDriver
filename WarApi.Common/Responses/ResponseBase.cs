﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WarApi.Responses
{
    public class ResponseBase<TData>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }

        [JsonProperty("meta")]
        public ResponseMetaData MetaData { get; set; }

        [JsonProperty("data")]
        public TData Data { get; set; }
    }
}