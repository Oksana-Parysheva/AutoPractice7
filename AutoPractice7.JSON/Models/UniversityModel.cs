using Newtonsoft.Json;
using System.Collections.Generic;

namespace AutoPractice7.JSON.Models
{
    public class UniversityModel
    {
        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("students")]
        public List<StudentModel> Students { get; set; }
    }
}
