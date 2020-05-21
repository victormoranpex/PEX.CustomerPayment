using PEX.CustomerPayment.Presentation.Helpers;
using PEX.CustomerPayment.Presentation.Models.Database;
using PEX.CustomerPayment.Presentation.Models.Database.SQL;
using PEX.CustomerPayment.Presentation.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PEX.CustomerPayment.Presentation.ViewModels
{
    public class DatosSoliitudViewModel
    {
        public Guid SolicitudPagoId { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string NumeroCuenta { get; set; }
        public string NumeroCuentaInterbancario { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string NacionalidadId { get; set; }
        public string CodigoBanco { get; set; }
        public string PaisOrigen { get; set; }
        public List<JsonEntity> LstBancos { get; set; }
        public List<JsonEntity> LstPaises { get; set; }
        public List<JsonEntity> LstTipoDocumeno { get; set; }

        public SolicitudPago SolicitudPago { get; set; }
        public bool ClienteRegistrado { get; set; }

        internal void Fill(CargarDatosContext cargarDatosContext, Guid transaccionId)
        {
            SolicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.TransactionId == transaccionId);

            LstBancos = ConstantHelpers.LstPaises;

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
        }

        internal void Register(CargarDatosContext cargarDatosContext)
        {

            var solicitudPago = cargarDatosContext.contextSql.SolicitudPago.FirstOrDefault(x => x.TransactionId == SolicitudPagoId);

            solicitudPago.Estado = "PRO";
            solicitudPago.NumeroCuenta = NumeroCuenta;
            solicitudPago.NumeroCuentaInterbancario = NumeroCuentaInterbancario;
            solicitudPago.CodigoBanco = CodigoBanco;

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
                    ocupacion = string.Empty,
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
                    cargo = string.Empty,
                    ciudad = string.Empty,
                    labor = string.Empty,
                    nombre = $"{Nombres} {ApellidoPaterno} {ApellidoMaterno}".Trim().RemoveSpecialCharacters(),
                    ocupa = string.Empty,
                    personeria = "N",
                    postal = string.Empty,
                    telefono = Telefono,
                    tipodoc = TipoDocumento,
                    usuario = "00",
                };
                cargarDatosContext.contextPg.clientes.Add(cliente);
                cargarDatosContext.contextPg.SaveChanges();
            }
            cargarDatosContext.contextSql.SaveChanges();
        }
    }
}