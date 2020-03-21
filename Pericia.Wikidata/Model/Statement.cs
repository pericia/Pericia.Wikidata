using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class Statement
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("mainsnak")]
        public Snak MainSnak { get; set; } = default!;

        [JsonPropertyName("rank")]
        public string Rank { get; set; } = default!;

        [JsonPropertyName("qualifiers")]
        public Dictionary<string, IEnumerable<Snak>> Qualifiers { get; set; } = default!;

        [JsonPropertyName("references")]
        public IEnumerable<Reference> References { get; set; } = default!;
    }


}
