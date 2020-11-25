using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Text;

namespace PEX.CustomerPayment.Presentation.Helpers
{
    public static class HttpClientExtensions
    {

        public static HttpContent CreateAsHttpContent(this object content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        public static HttpContent CreateAsHttpContentAsXml(this object content)
        {
            var xml = content.ToXML();
            return new StringContent(xml, Encoding.UTF8, "text/xml");
        }

        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
            }
        }

    }
}