//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEX.CustomerPayment.Presentation.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class nacional
    {
        public string numero { get; set; }
        public string origen { get; set; }
        public string codigo { get; set; }
        public Nullable<System.DateTime> fechaop { get; set; }
        public string isal { get; set; }
        public string moneda { get; set; }
        public string importemn { get; set; }
        public string importedo { get; set; }
        public string spot { get; set; }
        public string comision { get; set; }
        public string precio { get; set; }
        public string observaciones { get; set; }
        public string usuarioin { get; set; }
        public Nullable<System.DateTime> fechain { get; set; }
        public string horain { get; set; }
        public string anulado { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string agencia { get; set; }
        public string caja { get; set; }
        public string movim { get; set; }
        public string lotecaja { get; set; }
        public string anullote { get; set; }
        public string anulcaja { get; set; }
        public string oripa { get; set; }
        public string loteche { get; set; }
        public string lotecon { get; set; }
        public string operacon { get; set; }
        public string abonobco { get; set; }
        public string loteanu { get; set; }
        public string diferencia { get; set; }
        public string cambiohis { get; set; }
    
        public virtual agencia agencia1 { get; set; }
        public virtual caja caja1 { get; set; }
        public virtual moneda moneda1 { get; set; }
        public virtual usuario usuario1 { get; set; }
        public virtual usuario usuario2 { get; set; }
    }
}
