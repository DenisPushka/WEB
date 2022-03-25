using Newtonsoft.Json;

namespace Api.Models
{
    public class PersonJs
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("isMale")]
        public bool IsMale { get; set; }
        
        [JsonProperty("age")]
        public int Age { get; set; }
    }
}