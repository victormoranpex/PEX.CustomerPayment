using HelperKit.Mvc;
using PEX.CustomerPayment.Presentation.Models.Database;
using PEX.CustomerPayment.Presentation.Models.Database.SQL;
using PEX.CustomerPayment.Presentation.Models.General;

namespace PEX.CustomerPayment.Presentation.Controllers
{
    public class BaseController : HelperController
    {
        private CargarDatosContext cargarDatosContext; 

        protected CargarDatosContext CargarDatosContext()
        {
            if(cargarDatosContext == null)
            {
                cargarDatosContext = new Models.General.CargarDatosContext
                {
                    contextSql = new PexSqlEntities(),
                    contextPg = new GirosEntities(),
                    Session = Session
                };
            }

            return cargarDatosContext;
        }

        public override void InvalidateContext()
        {
            cargarDatosContext = null;
        }
    }
}