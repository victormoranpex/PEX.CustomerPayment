using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class ConsultaReferenciaViewModel
    {
        public int? SolicitudId { get; set; }

        public string NumeroReferencia { get; set; }
        public string NumeroDocumento { get; set; }

    }
}