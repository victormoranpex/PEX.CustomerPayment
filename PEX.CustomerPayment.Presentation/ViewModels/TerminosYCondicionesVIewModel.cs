using PEX.CustomerPayment.Presentation.Helpers;
using PEX.CustomerPayment.Presentation.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class TerminosYCondicionesVIewModel
    {
        public string TerminosYCondiciones { get; set; }


        internal void Fill(CargarDatosContext cargarDatosContext)
        {
            TerminosYCondiciones = cargarDatosContext.contextSql.ParametroConfiguracion.Where(x => x.CodigoParametro == ConstantHelpers.ParametroConfiguracion.Codigo_Terminos_Condiciones_Solicitud_Pago && x.FechaCaducidad == null).Select(x => x.ValorParametro).FirstOrDefault();
        }
    }
}