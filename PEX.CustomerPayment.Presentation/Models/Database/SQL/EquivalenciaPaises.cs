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
    
    public partial class EquivalenciaPaises
    {
        public int int_CodigoEquivalenciaPaises { get; set; }
        public string vch_AcronimoMoneyGram { get; set; }
        public string vch_DescripcionMoneyGram { get; set; }
        public string vch_AcronimoPEX { get; set; }
        public string vch_DescripcionPEX { get; set; }
        public string vch_PostalCodeFormat { get; set; }
        public Nullable<bool> HabilitadoWestern { get; set; }
    }
}
