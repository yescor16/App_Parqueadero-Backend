using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Negocio.Tarifa_Vehiculo;
using App.Transversal.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Parqueadero.Controllers
{
    [Route("api/[controller]")]
    public class TarifaVehhiculoController : Controller
    {
        private IUnidadDeTrabajo<Tarifa> TarifaVehhiculoRepositorio;

        public TarifaVehhiculoController(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaVehhiculoRepositorio = _repositorio;
        }

        //Obtener tarifa por vehiculo
        [HttpGet]
        [Route("ObtenerTarifaPorVehiculo/{id}")]
        public IEnumerable<Tarifa> ObtenerTarifaPorVehiculo(int id)
        {
            ObtenerTarifaPorVehiculo _obtenerTarifaPorVehiculo = new ObtenerTarifaPorVehiculo(TarifaVehhiculoRepositorio);
            return _obtenerTarifaPorVehiculo.Ejecutar(id);
        }

    }
}
