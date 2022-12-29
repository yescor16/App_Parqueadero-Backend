using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Negocio.OperacionesRegistroParqueadero;
using App.Negocio.Negocio.Tarifas;
using App.Transversal.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Parqueadero.Controllers
{
    [Route("api/[controller]")]
    public class RegistroParqueaderoController : Controller
    {
        private IUnidadDeTrabajo<RegistroParqueadero> RegistroParqueaderoepositorio;

        public RegistroParqueaderoController(IUnidadDeTrabajo<RegistroParqueadero> _repositorio)
        {
            this.RegistroParqueaderoepositorio = _repositorio;
        }

        //Insertar RegistroParqueadero
        [HttpPost]
        [Route("IngresoParqueadero")]
        public RegistroParqueadero IngresoParqueadero([FromBody] RegistroParqueadero _registroParqueadero)
        {
            IngresoRegistroParqueadero _crearIngresoParqueadero = new IngresoRegistroParqueadero(RegistroParqueaderoepositorio);
            return _crearIngresoParqueadero.Ejecutar(_registroParqueadero);
        }

        //Obtener el listado de Vehiculos sin salida
        [HttpGet]
        [Route("ObtenerVehiculosParqueados")]
        public IEnumerable<RegistroParqueadero> ObtenerVehiculosParqueados()
        {
            ObtenerVehiculosParqueados _obtenerVehiculosParqueados = new ObtenerVehiculosParqueados(RegistroParqueaderoepositorio);
            return _obtenerVehiculosParqueados.Ejecutar();
        }

        [HttpPost]
        [Route("ObtenerValorTarifaPorId")]
        public RegistroParqueadero ObtenerValorTarifaPorId([FromBody] RegistroParqueadero _registroParqueadero)
        {
            ObtenerValorTarifaPorId _obtenerValorTarifaPorId = new ObtenerValorTarifaPorId(RegistroParqueaderoepositorio);
            return _obtenerValorTarifaPorId.Ejecutar(_registroParqueadero);
        }

        
        [HttpPost]
        [Route("RegistroSalidaVehiculo")]
        public bool RegistroSalidaVehiculo([FromBody] RegistroParqueadero _registroParqueadero)
        {
            SalidaRegistroParqueadero _crearIngresoParqueadero = new SalidaRegistroParqueadero(RegistroParqueaderoepositorio);
            return _crearIngresoParqueadero.Ejecutar(_registroParqueadero);
        }

    }
}
