using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class User
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        [JsonIgnore]
        public string Result { get; set; }
    }
}