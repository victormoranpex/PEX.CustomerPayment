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
    
    public partial class Agencia
    {
        public int AgenciaID { get; set; }
        public string CodigoAgencia { get; set; }
        public string AgentID { get; set; }
        public string AgentSequence { get; set; }
        public string Token { get; set; }
        public System.DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> SobreGiro { get; set; }
        public Nullable<bool> RIA { get; set; }
        public string Grupo { get; set; }
        public string EntidadRecaudo { get; set; }
        public string EntidadSeguimientorecaudo { get; set; }
    }
}
