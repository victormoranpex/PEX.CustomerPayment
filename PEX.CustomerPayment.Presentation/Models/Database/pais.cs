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
    
    public partial class pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pais()
        {
            this.bancos = new HashSet<banco>();
            this.ciudades = new HashSet<ciudade>();
            this.clientes = new HashSet<cliente>();
            this.envios = new HashSet<envio>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string moneda { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string codigosunat { get; set; }
        public string mepais { get; set; }
        public string meoficina { get; set; }
        public string sensible { get; set; }
        public string topeenvios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<banco> bancos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ciudade> ciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<envio> envios { get; set; }
    }
}
