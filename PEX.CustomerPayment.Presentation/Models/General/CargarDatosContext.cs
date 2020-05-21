using PEX.CustomerPayment.Presentation.Models.Database;
using PEX.CustomerPayment.Presentation.Models.Database.SQL;
using System.Web;

namespace PEX.CustomerPayment.Presentation.Models.General
{
    public class CargarDatosContext
    {

        public PexSqlEntities contextSql { get; set; }
        public GirosEntities contextPg { get; set; }
        public HttpSessionStateBase Session { get; set; }

    }
}