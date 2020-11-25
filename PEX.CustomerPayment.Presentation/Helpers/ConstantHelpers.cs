using PEX.CustomerPayment.Presentation.ViewModels;
using System.Collections.Generic;

namespace PEX.CustomerPayment.Presentation.Helpers
{
    public static class ConstantHelpers
    {
        public static List<JsonEntity> LstPaises = new List<JsonEntity>
            {
                new JsonEntity { Id = "BCP", Text = "Banco de Crédito del Perú (BCP)" },
                new JsonEntity { Id = "IBK", Text = "Interbank" },
                new JsonEntity { Id = "BBVA", Text = "Banco Continental (BBVA)" },
                new JsonEntity { Id = "SCT", Text = "Scotiabank" },
                new JsonEntity { Id = "FLB", Text = "Banco Falabella" },
            };

        public static List<JsonEntity> LstTiposDocumento = new List<JsonEntity>
        {
            new JsonEntity { Id ="1", Text = "DNI"},
            new JsonEntity { Id = "4", Text = "Carnet de extranjería"},
            new JsonEntity { Id = "3", Text = "Pasaporte ó Cédula"},
            new JsonEntity { Id = "2", Text = "Permiso temporal de permanencia"}
        };

        public static List<JsonEntity> LstTipoMoneda = new List<JsonEntity>
        {
            new JsonEntity { Id = "USD", Text = "Dólares" },
            new JsonEntity { Id = "PEN", Text = "Soles" },
        };

        public static class ParametroConfiguracion
        {
            public const string Codigo_Terminos_Condiciones_Solicitud_Pago = "010001";
        }
    }
}