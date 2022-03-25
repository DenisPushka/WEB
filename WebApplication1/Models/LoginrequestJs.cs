using Newtonsoft.Json;

namespace WebApplication1.Models
{
    [JsonObject]
    public class LoginrequestJs
    {
        [JsonProperty("Логин")]
        public string Login { get; set; }
        
        [JsonProperty("Пароль")]
        public string Password { get; set; }
    }
}