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
    
    public partial class liquidacione
    {
        public string numero { get; set; }
        public string centro { get; set; }
        public Nullable<System.DateTime> fechaop { get; set; }
        public string cargoab { get; set; }
        public string importe { get; set; }
        public string tipopago { get; set; }
        public string referencia { get; set; }
        public string observaciones { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string caja { get; set; }
        public Nullable<int> origen { get; set; }
        public string bcocuenta { get; set; }
        public string documento { get; set; }
        public string movim { get; set; }
        public Nullable<System.DateTime> fechabco { get; set; }
        public string lotecon { get; set; }
        public string princom { get; set; }
    
        public virtual caja caja1 { get; set; }
        public virtual centro centro1 { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}