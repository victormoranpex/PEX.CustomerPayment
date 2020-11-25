using HelperKit;
using PEX.CustomerPayment.Presentation.Models.Database.SQL;
using PEX.CustomerPayment.Presentation.Models.General;
using PEX.CustomerPayment.Presentation.Servicios.Moneygram;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class ConsultaReferenciaViewModel
    {
        [Required]
        [Display(Name = "N° de referencia")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El N° de referencia debe tener 8 caracteres")]
        public string NumeroReferencia { get; set; }
        [Required]
        [Display(Name = "N° de documento de identidad")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "El N° de doc. debe tener entre 8 y 15 caracteres")]
        public string NumeroDocumento { get; set; }


        internal Guid Register(CargarDatosContext cargarDatosContext)
        {


            ServiceHandler serviceHandler = new ServiceHandler();
            var agencia = cargarDatosContext.contextSql.Agencia.FirstOrDefault(x => x.CodigoAgencia == "186");
            var response = serviceHandler.ReferenceNumber(NumeroReferencia, agencia.AgentID, agencia.AgentSequence, agencia.Token);
            var paisId = cargarDatosContext.contextSql.EquivalenciaPaises.FirstOrDefault(x => x.vch_AcronimoMoneyGram == response.OriginatingCountry);

            var estadoTransaccion = "";

            switch (response.TransactionStatus)
            {
                case "AVAIL":
                    estadoTransaccion = "Disponible";
                    break;
                case "CANCL":
                    estadoTransaccion = "Cancelada";
                    break;
                case "RECVD":
                    estadoTransaccion = "Recibida";
                    break;
                case "REFND":
                    estadoTransaccion = "Reembolsada";
                    break;
            }

            var solicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.NumeroReferencia == NumeroReferencia);

            if (solicitudPago == null)
            {
                solicitudPago = new SolicitudPago
                {
                    Estado = "INI",
                    FechaCreacion = DateTime.Now,
                    Moneda = response.ReceiveCurrency,
                    MontoTotal = response.ReceiveAmount.ToDecimal(),
                    NumeroReferencia = NumeroReferencia,
                    EstadoTransaccion = estadoTransaccion,
                    PaisOrigen = paisId.int_CodigoEquivalenciaPaises,
                    TransactionId = Guid.NewGuid(),
                    CodigoCliente = NumeroDocumento
                };
                cargarDatosContext.contextSql.SolicitudPago.Add(solicitudPago);
            }
            else
            {
                solicitudPago.EstadoTransaccion = estadoTransaccion;
            }

            cargarDatosContext.contextSql.SaveChanges();
            return solicitudPago.TransactionId;
        }


    }
}