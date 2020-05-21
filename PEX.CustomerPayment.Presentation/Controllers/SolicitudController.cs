using PEX.CustomerPayment.Presentation.ViewModels;
using System;
using System.Web.Mvc;

namespace PEX.CustomerPayment.Presentation.Controllers
{
    public class SolicitudController : BaseController
    {
        public ActionResult ConsultarReferencia()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConsultarReferencia(ConsultaReferenciaViewModel model)
        {
            var solicitudId = model.Register(CargarDatosContext());
            return RedirectToAction("MostrarDatosSolicitud", new { solicitudId });
        }


        public ActionResult MostrarDatosSolicitud(Guid solicitudId)
        {
            DatosSoliitudViewModel model = new DatosSoliitudViewModel();
            model.Fill(CargarDatosContext(), solicitudId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult MostrarDatosSolicitud(DatosSoliitudViewModel model)
        {
            try
            {
                model.Register(CargarDatosContext());
                return Json(new
                {
                    error = false,
                    message = $"SL{model.SolicitudPago.NumeroReferencia}"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    error = true,
                    message = ex.Message
                });

            }
        }

        public ActionResult FinalizarSolicitud(Guid solicitudId)
        {
            return View();
        }
    }
}