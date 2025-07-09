using System.Text.Json.Serialization;

namespace IntelligentApp.Models
{
    public class AnalyzeTextResponse
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("results")]
        public AnalyzeTextResults Results { get; set; }
    }
}
