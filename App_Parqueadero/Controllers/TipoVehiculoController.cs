using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Negocio.TipoVehiculos;
using App.Transversal.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Parqueadero.Controllers
{
    [Route("api/[controller]")]
    public class TipoVehiculoController : Controller
    {
        private IUnidadDeTrabajo<TipoVehiculo> TipoVehiculoRepositorio;

        public TipoVehiculoController(IUnidadDeTrabajo<TipoVehiculo> _repositorio)
        {
            this.TipoVehiculoRepositorio = _repositorio;
        }


        //Obtener el listado de tipos de vehiculos
        [HttpGet]
        [Route("ObtenerListadoTiposVehiculos")]
        public IEnumerable<TipoVehiculo> ObtenerListadoTiposVehiculos()
        {
            ObtenerListadoTipoVehiculos _obtenerListadoTipoVehiculos = new ObtenerListadoTipoVehiculos(TipoVehiculoRepositorio);
            return _obtenerListadoTipoVehiculos.Ejecutar();
        }


       
    }
}
 