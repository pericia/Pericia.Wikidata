using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class Reference
    {
        [JsonPropertyName("hash")]
        public string Hash { get; set; } = default!;

        [JsonPropertyName("snaks")]
        public Dictionary<string, IEnumerable<Snak>> Snaks { get; set; } = default!;
    }

}
