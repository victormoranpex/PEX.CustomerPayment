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
    
    public partial class envio
    {
        public string numero { get; set; }
        public string orden { get; set; }
        public string localidad { get; set; }
        public string destino { get; set; }
        public string cliente { get; set; }
        public string agencia { get; set; }
        public string importenet { get; set; }
        public string tarifa { get; set; }
        public string comision { get; set; }
        public string comisa { get; set; }
        public string monedaloc { get; set; }
        public Nullable<int> tipopago { get; set; }
        public string beneficiario { get; set; }
        public string telefono { get; set; }
        public string telefono2 { get; set; }
        public string banco { get; set; }
        public string tipocta { get; set; }
        public string cuenta { get; set; }
        public Nullable<int> usa { get; set; }
        public string bcofinal { get; set; }
        public string aba { get; set; }
        public string dirbco { get; set; }
        public string referen { get; set; }
        public string further { get; set; }
        public string bcointerm { get; set; }
        public string bcoincta { get; set; }
        public string mensaje { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<System.DateTime> fechaop { get; set; }
        public Nullable<System.DateTime> fechainc { get; set; }
        public string horainc { get; set; }
        public Nullable<System.DateTime> fechacar { get; set; }
        public Nullable<System.DateTime> fechapag { get; set; }
        public string bolfact { get; set; }
        public string docum { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string caja { get; set; }
        public string origen { get; set; }
        public string bcocuenta { get; set; }
        public string documento { get; set; }
        public string movim { get; set; }
        public Nullable<System.DateTime> fechabco { get; set; }
        public string cajaag { get; set; }
        public string movimag { get; set; }
        public Nullable<int> cuentapro { get; set; }
        public string itf { get; set; }
        public Nullable<int> sunat { get; set; }
        public string pais { get; set; }
        public string cerrado { get; set; }
        public string lotecon { get; set; }
        public string operacon { get; set; }
        public string direccion { get; set; }
        public string subagen { get; set; }
        public string mone_lote { get; set; }
        public Nullable<System.DateTime> mone_fecha { get; set; }
        public Nullable<System.DateTime> fecharch { get; set; }
        public string usuarch { get; set; }
        public string tarifan { get; set; }
        public string itfn { get; set; }
        public string igv { get; set; }
        public string direccion2 { get; set; }
        public string origen2 { get; set; }
        public string ciudad { get; set; }
        public string loteanu { get; set; }
        public string clientex { get; set; }
        public string soles { get; set; }
        public string tarifas { get; set; }
        public string igvs { get; set; }
        public string itfs { get; set; }
        public string liquidado { get; set; }
        public string vigorefe { get; set; }
    
        public virtual agencia agencia1 { get; set; }
        public virtual banco banco1 { get; set; }
        public virtual bcocuenta bcocuenta1 { get; set; }
        public virtual caja caja1 { get; set; }
        public virtual cliente cliente1 { get; set; }
        public virtual cuenta cuenta1 { get; set; }
        public virtual destino destino1 { get; set; }
        public virtual localidade localidade { get; set; }
        public virtual pais pais1 { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}