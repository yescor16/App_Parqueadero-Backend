using App.Dominio.IUnidadDeTrabajo;
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
    public class TarifaController : Controller
    {
        private IUnidadDeTrabajo<Tarifa> TarifaRepositorio;

        public TarifaController(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaRepositorio = _repositorio;
        }


        //Obtener el listado de Tarifas
        [HttpGet]
        [Route("ObtenerListadoTarifas")]
        public IEnumerable<Tarifa> ObtenerListadoTarifas()
        {
            ObtenerListadoDeTarifas _obtenerListadoDeTarifas = new ObtenerListadoDeTarifas(TarifaRepositorio);
            return _obtenerListadoDeTarifas.Ejecutar();
        }


        //Insertar Tarifa
        [HttpPost]
        [Route("CrearTarifa")]
        public Tarifa Crear([FromBody] Tarifa _tarifa)
        {
            CrearTarifa _crearTarifa = new CrearTarifa(TarifaRepositorio);
            return _crearTarifa.Ejecutar(_tarifa);
        }

        //Actualizar Tarifa
        [HttpPut]
        [Route("ActualizarTarifa")]
        public bool ActualizarTarifa([FromBody] Tarifa _tarifa)
        {
            ActualizarTarifa _actualizarTarifa = new ActualizarTarifa(TarifaRepositorio);
            return _actualizarTarifa.Ejecutar(_tarifa);
        }

       
    }
}
