using PEX.CustomerPayment.Presentation.Models.General;
using System;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class InformacionPagoViewModel
    {
        public Guid SolicitudPagoId { get; set; }
        public String NombreRemitente { get; set; }
        public String ApellidosRemitente { get; set; }
        public String TelefonoRemitente { get; set; }
        public String NombreBeneficiario { get; set; }
        public String ApellidosBeneficiario { get; set; }
        public String Moneda { get; set; }
        public Decimal? Monto { get; set; }
        public Decimal MontoRecibir { get; set; }
        public Decimal ITF { get; set; }
        public String NumeroReferencia { get; set; }
        public String PaisOrigen { get; set; }
        public String Estado { get; set; }
        public Int32 ReciboID { get; set; }
        public String TransaccionID { get; set; }

        public ConsultaReferenciaViewModel ConsultaReferenciaViewModel { get; set; }

        internal void Fill(CargarDatosContext cargarDatosContext, Guid solicitudPagoId)
        {

            //var solicitudPagoId = cargarDatosContext.conte

        }
    }
}