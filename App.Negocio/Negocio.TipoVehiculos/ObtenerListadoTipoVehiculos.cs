using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Util;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.TipoVehiculos
{
    public class ObtenerListadoTipoVehiculos
    {
        private IUnidadDeTrabajo<TipoVehiculo> TipoVehiculoRepositorio;
        public ObtenerListadoTipoVehiculos(IUnidadDeTrabajo<TipoVehiculo> _repositorio)
        {
            this.TipoVehiculoRepositorio = _repositorio;
        }
        public IEnumerable<TipoVehiculo> Ejecutar()
        {
            try
            {
                return TipoVehiculoRepositorio.repositorio<TipoVehiculo>().obtenerTodo();
            }
            catch (Exception error)
            {
                throw new Exception(new Excepcion().setError(Excepciones.ObtenerListadoTipoVehiculo),error);
            }
           
        }
    }
}
