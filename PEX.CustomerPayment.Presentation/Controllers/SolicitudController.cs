using PEX.CustomerPayment.Presentation.Logica;
using PEX.CustomerPayment.Presentation.Servicios.Sms;
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
            try
            {
                var solicitudId = model.Register(CargarDatosContext());
                return RedirectToAction("MostrarDatosSolicitud", new { solicitudId });
            }
            catch (Exception ex)
            {
                PostMessage(HelperKit.Mvc.MessageType.Danger, "No se ha encontrado una operación con el número de referencia ingresado");
                return View(model);
            }
            
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
                model.Register(CargarDatosContext(), Server.MapPath("~/EmailTemplates"));
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
            DatosSoliitudViewModel model = new DatosSoliitudViewModel();
            model.Fill(CargarDatosContext(), solicitudId);
            return View(model);
        }



        public ActionResult ConsultaSeguimiento(Guid ppst)
        {
            return RedirectToAction("MostrarDatosSolicitud", new { solicitudId = ppst });
        }

        public PartialViewResult _TerminosYCondiciones()
        {
            TerminosYCondicionesVIewModel model = new TerminosYCondicionesVIewModel();
            model.Fill(CargarDatosContext());
            return PartialView(model);
        }


        public ActionResult NotificarDeposito(Guid solicitudId)
        {
            DatosSoliitudViewModel model = new DatosSoliitudViewModel();
            model.Fill(CargarDatosContext(), solicitudId);
            model.EndPayment(CargarDatosContext(), Server.MapPath("~/EmailTemplates"));
            return Json(new
            {
                error = false,
                message = $"SL{model.SolicitudPago.NumeroReferencia}"
            });
        }

        public ActionResult Test()
        {
            SmsHandler smsHandler = new SmsHandler();
            smsHandler.SendMessage("Se ha registrado su solicitud. Para ver el estado ingrese a: https://peruexpress.cloud/pagos", "926974280");
            smsHandler.SendMessage("Se ha registrado su solicitud. Para ver el estado ingrese a: https://peruexpress.cloud/pagos", "984153422");
            return View();
        }

        public ActionResult SendEmail()
        {
            try
            {
                EmailSMTPService emailSMTPService = new EmailSMTPService();
                emailSMTPService.SendSingleEmail("vck1805@gmail.com", "TEST", "TEST");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }

    }
}