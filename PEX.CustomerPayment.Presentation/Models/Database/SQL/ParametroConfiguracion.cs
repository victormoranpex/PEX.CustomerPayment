//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEX.CustomerPayment.Presentation.Models.Database.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParametroConfiguracion
    {
        public int ParametroConfiguracionId { get; set; }
        public string CodigoParametro { get; set; }
        public string DescripcionParametro { get; set; }
        public string ValorParametro { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCaducidad { get; set; }
    }
}
