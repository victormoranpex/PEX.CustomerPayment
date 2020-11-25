using PEX.CustomerPayment.Presentation.Helpers;
using PEX.CustomerPayment.Presentation.Servicios.Sms.Model;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PEX.CustomerPayment.Presentation.Servicios.Sms
{
    public class SmsHandler
    {
        private readonly HttpClient httpClient;
        private readonly string token = "i50kuu8mx3b4mlfppvh6d79c";

        public SmsHandler()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["smsapi"])
            };
        }

        public void SendMessage(string mensaje, string celular)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.tuloenvias.com/sms/");
            byte[] bytes;
            XmlSerializer serializer = new XmlSerializer(typeof(envio));
            StringBuilder b = new StringBuilder();
            StringWriterUtf8 textWriter = new StringWriterUtf8(b);
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            envio envio = new envio()
            {
                codapi = token
            };


            envio.mensajes = new System.Collections.Generic.List<mensaje>
            {
                new mensaje { destinatario = celular, texto = mensaje }
            };

            serializer.Serialize(textWriter, envio, namespaces);
            bytes = System.Text.Encoding.ASCII.GetBytes(textWriter.ToString());
            request.ContentType = "application/xml";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
            }
        }

    }


    public class StringWriterUtf8 : StringWriter
    {
        public StringWriterUtf8(StringBuilder sb) : base(sb)
        {
        }
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}