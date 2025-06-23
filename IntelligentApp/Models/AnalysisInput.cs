using System.Text.Json.Serialization;

namespace IntelligentApp.Models
{
    public class AnalysisInput
    {
        [JsonPropertyName("documents")]
        public List<AnalysisDocument> Documents { get; set; }
    }
}
