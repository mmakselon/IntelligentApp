using System.Text.Json.Serialization;

namespace IntelligentApp.Models
{
    public class ErrorDetails
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
