﻿using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class Snak
    {
        [JsonPropertyName("snaktype")]
        public string SnakType { get; set; } = default!;

        [JsonPropertyName("property")]
        public string Property { get; set; } = default!;

        [JsonPropertyName("datatype")]
        public string DataType { get; set; } = default!;

        [JsonPropertyName("datavalue")]
        public SnakDataValueContainer? DataValue { get; set; }
    }

    public class SnakDataValueContainer
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
     
        //TODO :gestion values par type
        [JsonPropertyName("value")]
        public JsonElement Value { get; set; }
        public string? ValueId => Value.GetProperty("id").GetString();
        public string? ValueString => Value.GetString();
    }


}
