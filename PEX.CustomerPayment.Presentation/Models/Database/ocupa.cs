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
    
    public partial class ocupa
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string sbs { get; set; }
        public string sensible { get; set; }
        public string obligado { get; set; }
        public string nopercibe { get; set; }
        public string riesgo { get; set; }
        public string dependiente { get; set; }
        public string independiente { get; set; }
    
        public virtual usuario usuario1 { get; set; }
    }
}
