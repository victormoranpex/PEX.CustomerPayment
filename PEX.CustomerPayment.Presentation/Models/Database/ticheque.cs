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
    
    public partial class ticheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ticheque()
        {
            this.cheques = new HashSet<cheque>();
            this.dolares = new HashSet<dolare>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string portes { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cheque> cheques { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dolare> dolares { get; set; }
    }
}
