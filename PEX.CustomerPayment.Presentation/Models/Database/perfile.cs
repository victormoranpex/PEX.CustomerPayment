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
    
    public partial class perfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public perfile()
        {
            this.opciones = new HashSet<opcione>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string sistema { get; set; }
        public string aceenvios { get; set; }
        public string topeenvios { get; set; }
        public string acerecibos { get; set; }
        public string toperecibos { get; set; }
        public string anulrecibos { get; set; }
        public string anulenvios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<opcione> opciones { get; set; }
    }
}
