using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CesarWeb.Models;
using CesarWeb.Services;

namespace CesarWeb.Controllers
{
    public class CesarController : Controller
    {
        private ISeguridadService<int> _seguridadService;

        public CesarController(ISeguridadService<int> seguridadService)
        {
           _seguridadService = seguridadService;
        }


        [HttpPost]
        public IActionResult Encriptar(CesarViewModel mensajeAEncriptar)
        {
            mensajeAEncriptar.Mensaje = _seguridadService.Encriptar(mensajeAEncriptar.Mensaje, mensajeAEncriptar.Clave);
            return View(mensajeAEncriptar);
        }

        [HttpPost]
        public IActionResult DesEncriptar(CesarViewModel mensajeADesEncriptar)
        {
            mensajeADesEncriptar.Mensaje = _seguridadService.Encriptar(mensajeADesEncriptar.Mensaje, mensajeADesEncriptar.Clave);
            return View(mensajeADesEncriptar);
        }


    }
}
