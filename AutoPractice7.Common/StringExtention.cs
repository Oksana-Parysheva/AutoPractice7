using Newtonsoft.Json;
using System;

namespace AutoPractice7.Common
{
    public static class StringExtention
    {
        public static T As<T>(this string text)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(text);
            }
            catch (JsonException innerException)
            {
                throw new Exception("String contains not valid JSON data.", innerException);
            }
        }
    }
}
