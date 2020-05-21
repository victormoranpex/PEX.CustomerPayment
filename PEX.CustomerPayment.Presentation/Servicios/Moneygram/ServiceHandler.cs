using PEX.CustomerPayment.Presentation.Helpers;
using PEX.CustomerPayment.Presentation.ReferenceNumerServiceReference;
using PEX.CustomerPayment.Presentation.Servicios.Moneygram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEX.CustomerPayment.Presentation.Servicios.Moneygram
{
    public class ServiceHandler
    {

        public ReferenceNumberEntity ReferenceNumber(string numeroReferencia, string agentId, string agentSequence, string token)
        {
            using (MoneyGram_ReferenceNumberPortClient client = new MoneyGram_ReferenceNumberPortClient())
            {
                var response = client.referenceNumber(agentId, agentSequence, token, numeroReferencia);
                XmlHelper xh = new XmlHelper();
                return xh.Desirealize<ReferenceNumberEntity>(response);
            }


        }

    }
}