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
    
    public partial class marcacion
    {
        public string personal { get; set; }
        public System.DateTime fechaop { get; set; }
        public Nullable<int> secuencia { get; set; }
        public string seccion { get; set; }
        public string refrigerio { get; set; }
        public string sobre { get; set; }
        public string agencia { get; set; }
        public string ingreso { get; set; }
        public string salida { get; set; }
        public string feriado { get; set; }
        public string trabaja { get; set; }
        public string falta { get; set; }
        public string informa1 { get; set; }
        public string informa2 { get; set; }
        public string informa3 { get; set; }
        public string informa4 { get; set; }
        public string validas1 { get; set; }
        public string validas2 { get; set; }
        public string validas3 { get; set; }
        public string validas4 { get; set; }
        public string entraantes { get; set; }
        public string tardanza { get; set; }
        public string masrefri { get; set; }
        public string saleantes { get; set; }
        public string sobretpo { get; set; }
        public string referencia { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string usuario { get; set; }
        public string turno { get; set; }
        public string aprobado { get; set; }
    
        public virtual usuario usuario1 { get; set; }
    }
}
