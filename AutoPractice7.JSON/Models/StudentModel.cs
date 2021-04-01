using Newtonsoft.Json;

namespace AutoPractice7.JSON.Models
{
    public class StudentModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
