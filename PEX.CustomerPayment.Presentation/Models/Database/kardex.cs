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
    
    public partial class kardex
    {
        public string numero { get; set; }
        public string origen { get; set; }
        public string codigo { get; set; }
        public string lote { get; set; }
        public Nullable<System.DateTime> fechaop { get; set; }
        public string isal { get; set; }
        public string moneda { get; set; }
        public string importeme { get; set; }
        public string importedo { get; set; }
        public string spot { get; set; }
        public string comision { get; set; }
        public string precio { get; set; }
        public string observaciones { get; set; }
        public string usuarioin { get; set; }
        public Nullable<System.DateTime> fechain { get; set; }
        public string horain { get; set; }
        public string anulado { get; set; }
        public string historido { get; set; }
        public string liqdolares { get; set; }
        public Nullable<System.DateTime> liqfecha { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string caja { get; set; }
        public string oripa { get; set; }
        public string movim { get; set; }
        public string liquid { get; set; }
        public string importena { get; set; }
        public string cambiona { get; set; }
        public string ticamna { get; set; }
        public string lotecon { get; set; }
        public string confirmado { get; set; }
        public string lotecont { get; set; }
        public string loteanu { get; set; }
        public string diferencia { get; set; }
        public string cambiohis { get; set; }
    
        public virtual caja caja1 { get; set; }
        public virtual moneda moneda1 { get; set; }
        public virtual usuario usuario1 { get; set; }
        public virtual usuario usuario2 { get; set; }
    }
}
