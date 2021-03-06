﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = RemoveOAuthResponse.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class RemoveOAuthAccessResponse
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
