//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEX.CustomerPayment.Presentation.Models.Database.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitudPago
    {
        public int SolicitudPagoId { get; set; }
        public string CodigoCliente { get; set; }
        public string NumeroReferencia { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public string Estado { get; set; }
        public string CodigoAgencia { get; set; }
        public string CodigoUsuario { get; set; }
        public Nullable<int> ReciboMGID { get; set; }
        public string EstadoTransaccion { get; set; }
        public Nullable<int> PaisOrigen { get; set; }
        public Nullable<decimal> MontoTotal { get; set; }
        public string Moneda { get; set; }
        public System.Guid TransactionId { get; set; }
        public string NumeroCuenta { get; set; }
        public string NumeroCuentaInterbancario { get; set; }
        public string CodigoBanco { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string NumeroOperacionBanco { get; set; }
        public string FechaHoraOperacionBanco { get; set; }
        public string Correo { get; set; }
        public string TipoMoneda { get; set; }
        public Nullable<bool> EsClienteNuevo { get; set; }
        public string OrigenFondos { get; set; }
        public string DestinoFondos { get; set; }
        public string RelacionRemitente { get; set; }
    }
}
