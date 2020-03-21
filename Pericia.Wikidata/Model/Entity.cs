using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class Entity
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("labels")]
        public Dictionary<string, LocalizedString> Labels { get; set; } = default!;

        [JsonPropertyName("descriptions")]
        public Dictionary<string, LocalizedString> Descriptions { get; set; } = default!;

        [JsonPropertyName("aliases")]
        public Dictionary<string, IEnumerable<LocalizedString>> Aliases { get; set; } = default!;

        [JsonPropertyName("claims")]
        public Dictionary<string, IEnumerable<Statement>> Statements { get; set; } = default!;

        [JsonPropertyName("sitelinks")]
        public Dictionary<string, SiteLink> SiteLinks { get; set; } = default!;

        [JsonPropertyName("lastrevid")]
        public long LastRevId { get; set; }

        //[JsonPropertyName("modified")]
        //public DateTime? Modified { get; set; }
    }


}
