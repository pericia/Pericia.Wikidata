using System.Text.Json.Serialization;

namespace Pericia.Wikidata
{
    public class LocalizedString
    {
        [JsonPropertyName("language")]
        public string Language { get; set; } = default!;

        [JsonPropertyName("value")]
        public string Value { get; set; } = default!;
    }
}
