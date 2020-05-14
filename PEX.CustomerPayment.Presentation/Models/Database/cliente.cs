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
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.cajamovimcs = new HashSet<cajamovimc>();
            this.envios = new HashSet<envio>();
        }
    
        public string codigo { get; set; }
        public string personeria { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string postal { get; set; }
        public string agencia { get; set; }
        public string tipodoc { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string contacto { get; set; }
        public string documento { get; set; }
        public string banco { get; set; }
        public string tipocta { get; set; }
        public string cuenta { get; set; }
        public string consigna { get; set; }
        public string observaciones { get; set; }
        public string liquiefec { get; set; }
        public string liquicheq { get; set; }
        public string taricheq { get; set; }
        public Nullable<int> numlote { get; set; }
        public string nacion { get; set; }
        public string ocupa { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string exceptua { get; set; }
        public Nullable<System.DateTime> nacim { get; set; }
        public string excepitf { get; set; }
        public string senas { get; set; }
        public string labor { get; set; }
        public string cargo { get; set; }
        public string publico { get; set; }
        public Nullable<int> ope01 { get; set; }
        public Nullable<int> ope02 { get; set; }
        public Nullable<int> ope03 { get; set; }
        public Nullable<int> ope04 { get; set; }
        public Nullable<int> ope05 { get; set; }
        public Nullable<int> ope06 { get; set; }
        public Nullable<int> ope07 { get; set; }
        public Nullable<int> ope08 { get; set; }
        public Nullable<int> ope09 { get; set; }
        public Nullable<int> ope10 { get; set; }
        public Nullable<int> ope11 { get; set; }
        public Nullable<int> ope12 { get; set; }
        public string inusual { get; set; }
        public string checonsig { get; set; }
        public string penales { get; set; }
        public string fotocopia { get; set; }
        public string fotusuario { get; set; }
        public Nullable<System.DateTime> fotfecha { get; set; }
        public string estado { get; set; }
        public string dni { get; set; }
        public string ros { get; set; }
        public string judicial { get; set; }
        public string materno { get; set; }
        public string ruc { get; set; }
        public string distrito { get; set; }
        public string ciiu { get; set; }
        public string ofac { get; set; }
        public string motivofac { get; set; }
        public string ocupacion { get; set; }
        public string asignado { get; set; }
        public string oficial { get; set; }
        public string dnice { get; set; }
        public string exonera { get; set; }
        public string globokas { get; set; }
        public string pepcargo { get; set; }
        public string pepinsti { get; set; }
        public string pepdeclara { get; set; }
        public string oblitipo { get; set; }
        public string oblideclara { get; set; }
        public string peptipo { get; set; }
        public string reforza { get; set; }
        public string listas { get; set; }
        public string independiente { get; set; }
        public string calimanual { get; set; }
        public string calimotivo { get; set; }
        public string juritipo { get; set; }
        public string juritam { get; set; }
        public string juriaccio { get; set; }
        public string valorizacion { get; set; }
        public string juripep { get; set; }
        public string fechaval { get; set; }
    
        public virtual agencia agencia1 { get; set; }
        public virtual banco banco1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cajamovimc> cajamovimcs { get; set; }
        public virtual ciudade ciudade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<envio> envios { get; set; }
        public virtual pais pais { get; set; }
        public virtual postal postal1 { get; set; }
        public virtual cuenta cuenta1 { get; set; }
        public virtual documento documento1 { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}