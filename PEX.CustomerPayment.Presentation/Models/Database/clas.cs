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
    
    public partial class clas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clas()
        {
            this.activocs = new HashSet<activoc>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string ctacon { get; set; }
        public string ctacon2 { get; set; }
        public string deprecia { get; set; }
        public string ctaact { get; set; }
        public string ctagas { get; set; }
        public string ctadep { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activoc> activocs { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
