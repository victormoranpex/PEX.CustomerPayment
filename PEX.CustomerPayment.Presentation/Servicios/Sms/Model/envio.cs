using System.Collections.Generic;
using System.Xml.Serialization;

namespace PEX.CustomerPayment.Presentation.Servicios.Sms.Model
{
    [XmlRoot(ElementName = "mensaje")]
    public class mensaje
    {
        [XmlElement(ElementName = "destinatario")]
        public string destinatario { get; set; }
        [XmlElement(ElementName = "texto")]
        public string texto { get; set; }
    }

    [XmlRoot(ElementName = "envio")]
    public class envio
    {
        [XmlElement(ElementName = "codapi")]
        public string codapi { get; set; }

        [XmlArray("mensajes")]
        public List<mensaje> mensajes { get; set; }

    }

}