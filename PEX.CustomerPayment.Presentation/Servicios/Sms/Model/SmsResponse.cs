using System.Xml.Serialization;

namespace PEX.CustomerPayment.Presentation.Servicios.Sms.Model
{

    [XmlRoot(ElementName = "RESPUESTA")]
    public class SmsResponse
    {
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "mensaje")]
        public string Mensaje { get; set; }
    }
}