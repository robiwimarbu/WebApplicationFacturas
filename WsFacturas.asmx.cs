﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Negocio;
namespace WebApplicationFacturas
{
    /// <summary>
    /// Descripción breve de WsFacturas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WsFacturas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string Facturar(List<Factura> Facturas)
        {
            Factura.Procesar(Facturas);
            return "SI";
        }

        [WebMethod]
        public string ValidarFactura(Factura Factura)
        {
            return "";
        }
        [WebMethod]
        public string CalcularIVA(Factura Factura)
        {
            return "";
        }
    }
    
}
