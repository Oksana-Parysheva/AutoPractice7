using Newtonsoft.Json;
using System.Collections.Generic;

namespace AutoPractice7.JSON.Models
{
    public class UniversitiesModel
    {
        [JsonProperty("universities")]
        public List<UniversityModel> Universities { get; set; }
    }
}
