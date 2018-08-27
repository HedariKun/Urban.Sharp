using System;
using System.Net;
using System.Threading.Tasks;
using Urban.Sharp.Response;
using Newtonsoft.Json;

namespace Urban.Sharp
{
    public class UrbanClient
    {
        private const string BaseUrl = "http://api.urbandictionary.com/v0/define?term=";
        public static async Task<UrbanObject> GetDefinitionAsync(string Term)
        {
            string URL = BaseUrl + Term;
            return await GetJsonData<UrbanObject>(URL);
        }

        private static async Task<T> GetJsonData<T>(string URL) where T : new()
        {
            using(WebClient Web = new WebClient())
            {
                string JsonData = string.Empty;
                try
                {
                    JsonData = Web.DownloadString(URL);
                }
                catch(Exception)
                {
                    throw new Exception("Couldn't Find Definition");
                }
                await Task.CompletedTask;
                return !string.IsNullOrEmpty(JsonData)?  JsonConvert.DeserializeObject<T>(JsonData) : new T();
            }
        }
    }
}