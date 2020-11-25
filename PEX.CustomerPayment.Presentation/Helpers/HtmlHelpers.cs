using System.Web;

namespace PEX.CustomerPayment.Presentation.Helpers
{
    public static class HtmlHelpers
    {

        public static IHtmlString GetLabelEstadoSolicitud(string estado)
        {
            var result = string.Empty;
            var labelTemplate = "<label class=\"badge {0}\">{1}</label>";

            switch (estado)
            {
                case "INI":
                case "PRO":
                    result = string.Format(labelTemplate, "badge-warning", "En proceso");
                    break;
                case "PND":
                    result = string.Format(labelTemplate, "badge-info", "Depósito pendiente");
                    break;
                case "FNS":
                    result = string.Format(labelTemplate, "badge-success", "Pagado");
                    break;
            }
            return new HtmlString(result);
        }

    }
}