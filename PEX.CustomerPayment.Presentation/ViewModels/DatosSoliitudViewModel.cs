using Foolproof;
using PEX.CustomerPayment.Presentation.Helpers;
using PEX.CustomerPayment.Presentation.Logica;
using PEX.CustomerPayment.Presentation.Models.Database;
using PEX.CustomerPayment.Presentation.Models.Database.SQL;
using PEX.CustomerPayment.Presentation.Models.General;
using PEX.CustomerPayment.Presentation.Servicios.Sms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class DatosSoliitudViewModel
    {
        public Guid SolicitudPagoId { get; set; }
        [RequiredIf("ClienteRegistrado", false)]
        public string Nombres { get; set; }
        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "Tipo de documento")]
        public string TipoDocumento { get; set; }
        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "N° de documentp de identidad")]
        public string NumeroDocumento { get; set; }
        [Required]
        [Display(Name = "Correo")]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        [Display(Name = "N° cuenta bancario")]
        public string NumeroCuenta { get; set; }
        [Required]
        [Display(Name = "N° cuenta interbancario")]
        public string NumeroCuentaInterbancario { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [RequiredIf("ClienteRegistrado", false)]
        public DateTime? FechaNacimiento { get; set; }

        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [RequiredIf("ClienteRegistrado", false)]
        [Display(Name = "Nacionalidad")]
        public string NacionalidadId { get; set; }
        [Required]
        [Display(Name = "Banco")]
        public string CodigoBanco { get; set; }
        public string PaisOrigen { get; set; }
        [Display(Name = "Cargo")]
        [RequiredIf("ClienteRegistrado", false)]
        public string Cargo { get; set; }
        public string Ocupacion { get; set; }
        [Display(Name = "Centro de labores")]
        [RequiredIf("ClienteRegistrado", false)]
        public string CentroLaboral { get; set; }
        public List<JsonEntity> LstBancos { get; set; }
        public List<JsonEntity> LstPaises { get; set; }
        public List<JsonEntity> LstTipoDocumeno { get; set; }
        public List<JsonEntity> LstOcupaciones { get; set; }
        [Required]
        [Display(Name = "Moneda de la cuenta")]
        public string TipoMoneda { get; set; }
        public List<JsonEntity> LstTipoMonedas { get; set; }

        public SolicitudPago SolicitudPago { get; set; }
        public bool ClienteRegistrado { get; set; }
        [Display(Name = "Acepto los términos y condiciones")]
        [Required(ErrorMessage = "Debe aceptar los términos y condiciones del servicio")]
        public bool TerminosYCondiciones { get; set; }

        [Display(Name = "Origen de los fondos")]
        [Required]
        public string OrigenFondos { get; set; }
        [Required]
        [Display(Name = "Destino de los fondos")]
        public string DestinoFondos { get; set; }
        [Required]
        [Display(Name = "Relacion con el remitente")]
        public string RelacionRemitente { get; set; }

        internal void Fill(CargarDatosContext cargarDatosContext, Guid transaccionId)
        {
            SolicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.TransactionId == transaccionId);

            LstBancos = ConstantHelpers.LstPaises;
            LstTipoMonedas = ConstantHelpers.LstTipoMoneda;
            LstOcupaciones = cargarDatosContext.contextPg.ocupas.Select(x => new JsonEntity
            {
                Id = x.codigo,
                Text = x.nombre
            }).ToList();

            LstPaises = cargarDatosContext.contextPg.paises.Select(x => new JsonEntity
            {
                Id = x.codigo,
                Text = x.nombre
            }).ToList();

            LstTipoDocumeno = ConstantHelpers.LstTiposDocumento;

            var cliente = cargarDatosContext.contextPg.clientes.FirstOrDefault(x => x.codigo == SolicitudPago.CodigoCliente);
            ClienteRegistrado = cliente != null;

            PaisOrigen = cargarDatosContext.contextSql.EquivalenciaPaises.FirstOrDefault(x => x.int_CodigoEquivalenciaPaises == SolicitudPago.PaisOrigen).vch_DescripcionPEX;

            NumeroDocumento = SolicitudPago.CodigoCliente;
            SolicitudPagoId = SolicitudPago.TransactionId;
            NumeroCuenta = SolicitudPago.NumeroCuenta;
            NumeroCuentaInterbancario = SolicitudPago.NumeroCuentaInterbancario;
            CodigoBanco = SolicitudPago.CodigoBanco;
            Celular = SolicitudPago.Celular;
            Telefono = SolicitudPago.Telefono;
        }

        internal void Register(CargarDatosContext cargarDatosContext, string serverPath)
        {
            var solicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.TransactionId == SolicitudPagoId);

            if (solicitudPago.Estado == "FNS")
            {
                return;
            }

            solicitudPago.NumeroCuenta = NumeroCuenta;
            solicitudPago.NumeroCuentaInterbancario = NumeroCuentaInterbancario;
            solicitudPago.CodigoBanco = CodigoBanco;
            solicitudPago.Celular = Celular;
            solicitudPago.Telefono = Telefono;
            solicitudPago.Correo = Correo;
            solicitudPago.TipoMoneda = TipoMoneda;
            solicitudPago.OrigenFondos = OrigenFondos;
            solicitudPago.DestinoFondos = DestinoFondos;
            solicitudPago.RelacionRemitente = RelacionRemitente;

            if (solicitudPago.Estado == "INI")
            {
                var cliente = cargarDatosContext.contextPg.clientes.FirstOrDefault(x => x.codigo == NumeroDocumento);

                if (cliente == null)
                {
                    cliente = new cliente
                    {
                        codigo = NumeroDocumento,
                        nombres = Nombres.RemoveSpecialCharacters(),
                        apellidos = ApellidoPaterno.RemoveSpecialCharacters(),
                        materno = ApellidoMaterno.RemoveSpecialCharacters(),
                        direccion = Direccion.RemoveSpecialCharacters(),
                        nacion = NacionalidadId,
                        nacim = FechaNacimiento,
                        agencia = "001",
                        senas = "ninguna",
                        fax = string.Empty,
                        contacto = string.Empty,
                        documento = string.Empty,
                        cuenta = string.Empty,
                        consigna = string.Empty,
                        observaciones = string.Empty,
                        liquiefec = string.Empty,
                        liquicheq = string.Empty,
                        taricheq = string.Empty,
                        numlote = 0,
                        exceptua = string.Empty,
                        ope01 = 0,
                        ope02 = 0,
                        ope03 = 0,
                        ope04 = 0,
                        ope05 = 0,
                        ope06 = 0,
                        ope07 = 0,
                        ope08 = 0,
                        ope09 = 0,
                        ope10 = 0,
                        ope11 = 0,
                        ope12 = 0,
                        inusual = string.Empty,
                        checonsig = string.Empty,
                        penales = string.Empty,
                        fotocopia = string.Empty,
                        fotusuario = string.Empty,
                        estado = string.Empty,
                        dni = string.Empty,
                        ros = string.Empty,
                        judicial = string.Empty,
                        ruc = string.Empty,
                        distrito = string.Empty,
                        ciiu = string.Empty,
                        ofac = string.Empty,
                        motivofac = string.Empty,
                        ocupacion = Ocupacion,
                        asignado = string.Empty,
                        oficial = string.Empty,
                        dnice = string.Empty,
                        exonera = string.Empty,
                        globokas = string.Empty,
                        pepcargo = string.Empty,
                        pepinsti = string.Empty,
                        pepdeclara = string.Empty,
                        oblitipo = string.Empty,
                        oblideclara = string.Empty,
                        peptipo = string.Empty,
                        reforza = string.Empty,
                        listas = string.Empty,
                        independiente = string.Empty,
                        calimanual = string.Empty,
                        calimotivo = string.Empty,
                        juritipo = string.Empty,
                        juritam = string.Empty,
                        juriaccio = string.Empty,
                        valorizacion = string.Empty,
                        juripep = string.Empty,
                        fechaval = string.Empty,
                        cargo = Cargo,
                        ciudad = "LIM",
                        labor = CentroLaboral,
                        nombre = $"{Nombres} {ApellidoPaterno} {ApellidoMaterno}".Trim().RemoveSpecialCharacters(),
                        ocupa = Ocupacion,
                        personeria = "N",
                        postal = "101",
                        telefono = Telefono,
                        tipodoc = TipoDocumento,
                        usuario = "00",
                        fecha = DateTime.Now,
                        publico = "",
                        banco = "",
                        excepitf = "",
                        fotfecha = null,
                        tipocta = "",
                    };
                    cargarDatosContext.contextPg.clientes.Add(cliente);
                    cargarDatosContext.contextPg.SaveChanges();
                    solicitudPago.EsClienteNuevo = true;
                }

                EmailSMTPService emailSMTPService = new EmailSMTPService();
                string body = System.IO.File.ReadAllText(Path.Combine(serverPath, "solicitud_registrada.html"));
                body = body.Replace("%NOMBRES%", cliente.nombres.Split(' ').FirstOrDefault());
                body = body.Replace("%PAGO_ID%", SolicitudPagoId.ToString());
                emailSMTPService.SendSingleEmail(Correo, "Solicitud de pago registrada", body);

                if (!Celular.IsNullOrEmpty() && Celular.Length == 9)
                {
                    string mensajeSms = "Se ha registrado su solicitud. Para ver el estado ingrese a: https://peruexpress.cloud/pagos";

                    SmsHandler smsHandler = new SmsHandler();
                    smsHandler.SendMessage(mensajeSms, Celular);
                }
            }
            solicitudPago.Estado = "PRO";
            cargarDatosContext.contextSql.SaveChanges();
        }

        internal void EndPayment(CargarDatosContext cargarDatosContext, string serverPath)
        {
            var solicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.TransactionId == SolicitudPagoId);
            var cliente = cargarDatosContext.contextPg.clientes.FirstOrDefault(x => x.codigo == NumeroDocumento);
            Celular = solicitudPago.Celular;
            Correo = solicitudPago.Correo;

            EmailSMTPService emailSMTPService = new EmailSMTPService();
            string body = System.IO.File.ReadAllText(Path.Combine(serverPath, "solicitud_pagada.html"));
            body = body.Replace("%NOMBRES%", cliente.nombres.Split(' ').FirstOrDefault());
            body = body.Replace("%PAGO_ID%", SolicitudPagoId.ToString());
            emailSMTPService.SendSingleEmail(Correo, "Solicitud de pago depositada", body);


            if (!Celular.IsNullOrEmpty() && Celular.Length == 9)
            {
                string mensajeSms = $"Hola {cliente.nombres.Split(' ').FirstOrDefault()} su pago ya ha sido depositado en su cuenta, gracias por su preferencia";

                SmsHandler smsHandler = new SmsHandler();
                smsHandler.SendMessage(mensajeSms, Celular);
            }

        }
    }
}