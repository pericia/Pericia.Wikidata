using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class SiteLink
    {
        [JsonPropertyName("site")]
        public string Site { get; set; } = default!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        [JsonPropertyName("badges")]
        public IEnumerable<string> Badges { get; set; } = default!;
    }
}
