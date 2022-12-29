using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Negocio.Reportes;
using App.Transversal.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Parqueadero.Controllers
{
    [Route("api/[controller]")]
    public class ReportesParqueaderoController : Controller
    {
        private IUnidadDeTrabajo<ReporteVehiculosConSalidaPorTiempo> Repositorio;

        public ReportesParqueaderoController(IUnidadDeTrabajo<ReporteVehiculosConSalidaPorTiempo> _repositorio)
        {
            this.Repositorio = _repositorio;
        }

        [HttpPost]
        [Route("ReporteVehiculosConSalidaPorTiempo")]
        public IEnumerable<ReporteVehiculosConSalidaPorTiempo> ReporteVehiculosConSalidaPorTiempo([FromBody] RequestReporteVehiculosConSalidaPorTiempo fechasParam)
        {
            ObtenerVehiculosParqueadosPorTiempos _obtenerVehiculosParqueadosPorTiempos = new ObtenerVehiculosParqueadosPorTiempos(Repositorio);
            return _obtenerVehiculosParqueadosPorTiempos.Ejecutar(fechasParam);
        }
    }
}
