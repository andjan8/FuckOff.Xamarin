using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;





namespace FuckOff.Service
{
    public class WebRequestWrapper
    {
        public async Task<FuckOffMessage> GetResponseAsync(string requestUri)
        {
            if (string.IsNullOrWhiteSpace(requestUri))
            {
                throw new EmptyUrlException("FUCK! The request string was fucking empty!!!");
            }
            else
            {
                return await _GetResponseAsync(requestUri);
            }
        }

        protected virtual async Task<FuckOffMessage> _GetResponseAsync(string requestUri)
        { 
            FuckOffMessage message = new FuckOffMessage();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {

                string resultString = await response.Content.ReadAsStringAsync();
                message = ParseJson(resultString);
            }
            return message;

           
        }

        public FuckOffMessage ParseJson(string json)
        {
            FuckOffMessage message = new FuckOffMessage();
            JObject obj = JObject.Parse(json);
            message.Message  = obj["message"].Value<string>();
            message.Subtitle = obj["subtitle"].Value<string>();
            
            //"\"{\"message\":\"Version 1.1.0\",\"subtitle\":\"FOAAS\"}\""
            

            //string[] parts = json.Split(':');
            //message.Message = parts[1].Split(',')[0].Replace("\"","");
            //message.Subtitle = parts[2].Replace("}","").Replace("\"","");
            return message;
        }
    }

    public class FuckOffMessage
    {
        public string Message;
        public string Subtitle;
    }
}
