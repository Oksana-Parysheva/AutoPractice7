using AutoPractice7.Common;
using AutoPractice7.JSON.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoPractice7.JSON
{
    class Program
    {
        const string JsonFile = "universities.json";

        static void Main()
        {
            string jsonText = File.ReadAllText(JsonFile);
            Console.WriteLine("JSON string is:\n{0}\n", jsonText);

            UniversitiesModel jsonObject = jsonText.As<UniversitiesModel>();
            var jsonString = JsonConvert.SerializeObject(jsonObject);

            JObject o = JObject.Parse(jsonText);
            string universityName = o["universities"][0]["university"].Value<string>();
            List<string> students = o["universities"][0]["students"].
                            Children()["name"].
                            Select(p => p.Value<string>()).
                            ToList();

            Console.ReadLine();
        }
    }
}
